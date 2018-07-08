using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILP
{
    public class InductionEngine
    {
        static int cnt = 0;
        public int MaxSteps;
        double positiveThreshold = 80;
        double negativeThreshold = 50;
        public void setPosThresh(double t) { positiveThreshold = t; }
        public void setNegThresh(double t) { negativeThreshold = t; }
        private void variablize(Clause p)
        {
            cnt = p.maxIndex()+1;
            Dictionary<string, string> replaceList = new Dictionary<string, string>();
            //TODO: check the count of f1:  more than one add f1
            foreach (Literal pc in p.getPSide())
                foreach (string f1 in pc.items)
                    if(!f1.StartsWith("X"))
                    if (p.numberOfOccurence(f1) > 1)
                        if (!replaceList.ContainsKey(f1))
                        {
                            replaceList.Add(f1, "X" + cnt);
                            cnt++;
                        }

            foreach (KeyValuePair<string, string> kv in replaceList.ToArray())
                if (p.containsMoreThanOne(kv.Key))
                    p.replace(kv.Key, kv.Value);
            p.replaceList = replaceList;

        }
        ArrayList trainSet = new ArrayList();
        ArrayList testSet = new ArrayList();
        ArrayList negTrainSet = new ArrayList();
        ArrayList negTestSet = new ArrayList();
        //    ArrayList backgrounds = new ArrayList();
        FastHashCollection fastHash = new FastHashCollection();
        public void makeBackground(string[] s)
        {
            int j = 0;
            //     backgrounds = new ArrayList();
            fastHash.clearBackgrounds();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s != null) && s[i] != null && (s[i] != ""))
                {
                    Literal c = new Literal(s[i]);
                    c.serial = j;
                    j++;
                    fastHash.addBackground(c);
                }
            }
            //   return backgrounds;
        }
        public int trainPercent;
        int test = 0;
        int train = 0;
        public ArrayList getTrainSet()
        {
            return trainSet;
        }

        public ArrayList getTestSet()
        {
            return testSet;
        }

        public void makePositives(string[] s)
        {
            train = 0;
            test = 0;
            //        Random rand = new Random();
            trainSet = new ArrayList();
            testSet = new ArrayList();
            //int noOfNeededPos = trainPercent * s.Count();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s != null) && s[i] != null && (s[i] != ""))
                {
                    Literal c = new Literal(s[i]);
                    c.covered = false;
                    int rnd = rand.Next(0, 100);
                    //    Log.logLine(rnd);
                    if (rnd <= trainPercent)
                    {
                        c.train = true;
                        train++;
                        trainSet.Add(c);

                    }
                    else
                    {
                        test++;
                        c.train = false;
                        testSet.Add(c);
                    }
                   
                }
            }


        }
        //ArrayList negatives = new ArrayList();

        public void makeNegatives(string[] s)
        {
            negTrainSet = new ArrayList();
            negTestSet = new ArrayList();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s != null) && s[i] != null && (s[i] != ""))
                {
                    Literal c = new Literal(s[i]);
                    int rnd = rand.Next(0, 100);
                    //    Log.logLine(rnd);
                    if (rnd <= trainPercent)
                    {
                        negTrainSet.Add(c);
                        c.train = true;
                    }
                    else
                    {
                        c.train = false;
                        negTestSet.Add(c);
                    }
                 

                }

            }
           
        }
        private void makeHash()
        {
            hash.clear();
            foreach (Literal c in fastHash.getBackgrounds())
            {
                foreach (string s in c.items)
                    hash.Add(s, c);
            }
        }
        HashMap hash = new HashMap();

        private ArrayList subset(HashSet<Literal> ps)
        {
            ArrayList result = new ArrayList();
            int n = ps.Count;
            int[] adder = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
                adder[i] = 0;
            do
            {
                HashSet<Literal> ss = new HashSet<Literal>();
                for (int i = 1; i < n + 1; i++)
                {
                    if (adder[i] == 1)
                        ss.Add(ps.ElementAt(i - 1));

                }
                result.Add(ss);
                // Log.logLine();
                if (adder[n] == 0)
                {
                    adder[n] = 1;
                }
                else
                {
                    int l = n;
                    while (adder[l] == 1)
                    {
                        adder[l] = 0;
                        l--;
                    }
                    adder[l] = 1;
                }
            }
            while (adder[0] == 0);
            return result;
        }
        public bool generateNegative(Clause pred)
        {
            int k = 0;
            int t = 0;
            int noOfClauseToCheck = 100;
            ResolutionManager rm = new ResolutionManager();
           // int negTresh = (int)(noOfClauseToCheck * noOfClauseToCheck / negatives.Count);
            foreach (Literal c in negTrainSet)
            {
                if (rand.Next(negTrainSet.Count) < noOfClauseToCheck)
                {
                    t++;
                    Clause p = pred.clone();

                    if (rm.checkCoverage(p, c))
                    {      // return true;
                        k++;
                        c.covered = true;
                    }
                }
            }
            pred.negativeCoverage = (100.0 * k / t);
            if (pred.negativeCoverage  > negativeThreshold)
                return true;
            return false;
        }
        public double computeCoverage(Clause pred, bool mark, bool fast) // the min coverage assumed to be five
        {
            ResolutionManager rm = new ResolutionManager();
            int pcount = 0;
            int total = 0;
            foreach (Literal c in trainSet)
            {
                        Clause p = pred.clone();
                        total++;
                        if (rm.checkCoverage(p, c))
                        {
                            pcount++;
                            c.covered = true;
                            if (mark)
                                c.visited = true;
                        }
                        if (pcount > 5)
                            return 100.0 * pcount / total;
                //TODO: change 104
                //  if (fast && total > 104)
                //    break;
            }
            double posCoverage = 0;
            if (total == 0)
                posCoverage = 0;
            else
                posCoverage = 100.0 * pcount / total;
            pred.positiveCoverage = posCoverage;
            return posCoverage;
        }
        public void computeTestCoverage(Clause pred)
        {
            ResolutionManager rm = new ResolutionManager();
            int pcount = 0;
            int total = 0;
            foreach (Literal c in testSet)
            {
                if (!c.covered)
                {
                    Clause p = pred.clone();
                    total++;
                    if (rm.checkCoverage(p, c))
                    {
                        pcount++;
                        c.covered = true;
                    }
                 }
            }
        }
        bool ShowwOnlyVariablized = true;
        public void removeNonVariablized()
        {
            if (!ShowwOnlyVariablized) return;
            ArrayList removeList = new ArrayList();
            int size = predicates.Count;
            for (int i = 0; i < size; i++)
            {
                if (!((Clause)predicates[i]).FullyVariable())
                    removeList.Add(predicates[i]);


            }
            foreach (Clause p in removeList)
                predicates.Remove(p);

        }
        public void removeRedundant()
        {
            int size = predicates.Count;
            for (int i = 0; i < size; i++)
                for (int j = i + 1; j < size; j++)
                    if (((Clause)predicates[i]).ToString().CompareTo( ((Clause)predicates[j]).ToString()) > 0)
                    {
                        Object temp = predicates[i];
                        predicates[i] = predicates[j];
                        predicates[j] = temp;

                    }
            ArrayList removeList = new ArrayList();
            for (int i = 0; i < size - 1; i++)
                if (((Clause)predicates[i]).ToString().CompareTo(((Clause)predicates[i + 1]).ToString()) == 0)
                    removeList.Add(predicates[i+1]);
            foreach (Clause p in removeList)
                predicates.Remove(p);



        }


        public void computeDetectionRate(ArrayList list,ref double recall,ref double precision,ref double fmeasure, ref double accuracy)
        {
            resetTestCoverage();
        
            ResolutionManager rm = new ResolutionManager();

            int P = 0;
            double detected = 0;
            //TODO: PARALLEL
            Object[] cc = list.ToArray();

            if (PARALLEL)
            {
                Parallel.For(0, list.Count, i =>
                {
                    cnt++;
                    Clause p = (Clause)cc[i];
                    computeTestCoverage(p);
                });
            }
            else {
                 foreach (Clause p in list)
                    computeTestCoverage(p);
            }
            foreach (Literal c in testSet)
            {
                P++;
                if (c.covered)
                    detected++;
            }
            //TODO: PARALLEL
            int negCov = 0;
            int N = 0;
          foreach (Literal c in negTestSet)
          {
                    N++;                              
                    foreach (Clause p in list)
                    {
                        Clause p2 = p.clone();
                        if (rm.checkCoverage(p2, c))
                        {
                            c.covered = true;
                            negCov++;
                            break;
                        }
                    }                
            }
            //TP: detected. FP: negCov   TN: N - FP,   FN: P - TP
            //prec = tp / (tp + fp)
            //recall = tp / p

            //   precision = 100 - ( 100.0 * negCov / negatives.Count);
            precision = 100.0 * detected / (detected + negCov);
            recall = 100.0 * detected / P;
            if (precision + recall == 0)
                fmeasure = 0;
            else
                fmeasure = 2 * recall * precision / (precision + recall);
            accuracy = 100.0 * (detected + N - negCov) / (N + P);

            precision = Math.Round(precision, 2);
            recall = Math.Round(recall, 2);
            fmeasure = Math.Round(fmeasure, 2);
            accuracy = Math.Round(accuracy, 2);
        }
   //     bool turbo = false;
        public void resetTrainCoverage()
        {
            foreach (Literal c in trainSet)
            {
                c.covered = false;
                c.visited = false;
            }
            foreach (Literal c in negTrainSet)
                c.covered = false;
        }
        public void resetTestCoverage()
        {
            foreach (Literal c in testSet)
            {
                c.covered = false;
                c.visited = false;
            }
            foreach (Literal c in negTestSet)
                c.covered = false;
        }

        public int numberOfRules()
        {
            return predicates.Count;
        }
        ArrayList predicates = new ArrayList();
        private bool contains(Clause np)
        {
            foreach (Clause p in predicates)
            {

                if (p != np)
                    if (p.equals(np))
                        return true;
            }
            return false;
        }

      
        public void removeNegativePredicates(ArrayList list)
        {
            ArrayList removeItems = new ArrayList();
            foreach (Clause p in list)
                if (generateNegative(p))
                    removeItems.Add(p);
            foreach (Clause p in removeItems)
                list.Remove(p);


        }
      
        Random rand = new Random();
        public int mode;
        //TODO: how to partition background knowledge
        const int MODE_RANDOM = 1;
        const int MODE_COVERAGE = 2;
        const int MODE_ALLPREDICATES = 0;
        const int MODE_COUNT_CONSTANTS = 3;
        

        public double score(Clause p)
        {
            double d = 0;

            if (mode == MODE_RANDOM)//random
            {
                if (p.score > -1)
                    return p.score;
                d = rand.Next(10);
                p.score = d;

            }

            if (mode == MODE_COVERAGE)//coverage
            {
                double posCoverage = computeCoverage(p, false, true);
                d = posCoverage;

            }
            if (mode == MODE_ALLPREDICATES) //constant
            {
                d = 3;
            }
            if(mode == MODE_COUNT_CONSTANTS)
            {
                d = 10000 - p.countOfConstants();
            }
            return d;
        }

        public ArrayList prune(ref double recallMeasure, ref double precisionMeasure,ref double FScore, ref double accuracyMeasure )
        {
            ArrayList list = new ArrayList();
            foreach (Clause p in predicates)
                list.Add(p);
            //TODO:
            removeNegativePredicates(list);
            foreach (Clause p in list)
            {
                p.quality = p.positiveCoverage - p.negativeCoverage;
            }
            int size = list.Count;
            for (int i = 0; i < size; i++)
                for (int j = i + 1; j < size; j++)
                    if (((Clause)list[i]).quality < ((Clause)list[j]).quality)
                    {
                        Object tempObj = list[i];
                        list[i] = list[j];
                        list[j] = tempObj;

                    }
            double recall = 0;
            double precision = 0;
            double fmeasure = 0;
            double accuracy = 0;
            computeDetectionRate(list, ref recall, ref precision, ref fmeasure,ref accuracy);
            Console.WriteLine(list.Count+" recall: "+recall + " pec: " + precision + "f: "+fmeasure +" acc: "+accuracy);
            int begin = 0;
            int mid = list.Count / 2;
            int end = list.Count;
            ArrayList list2 = new ArrayList();
           
            while (end - begin > 2)
            {
                if (list.Count == 0) break; 
                list2.Clear();
                Console.WriteLine(begin + " " + mid + " " + end);
                for (int i = 0; i < mid; i++)
                    list2.Add(list[i]);
                double recall2 = 0;
                double precision2 = 0;
                double fmeasure2 = 0;
                double accuracy2 = 0;
                computeDetectionRate(list2, ref recall2, ref precision2,ref fmeasure2,ref accuracy2);
                Console.WriteLine(list2.Count + " recall: " + recall2 + " pec: " + precision2 + "f: " + fmeasure2 + " acc: " + accuracy2);


                if (accuracy2 >= accuracy)
                {
                    end = mid;
                    mid =  mid/ 2;
                    recall = recall2;
                    precision = precision2;
                    fmeasure = fmeasure2;
                    accuracy = accuracy2;
                }
                else
                {
                    begin = mid;
                    mid = (end + mid) / 2;
                   // flag = false;
                }
                

                
            }
            recallMeasure = recall;
            precisionMeasure = precision;
            FScore = fmeasure;
            accuracyMeasure = accuracy;
            return list2;

        }
        public void sortVariables(Clause p)
        {
            string s = p.ToString();
            int index = 0;
            int index2 = 0;
            int i = 0;
            while (index != -1)
            {
                index = s.IndexOf("X", index2);
                if (index != -1)
                {
                    index2 = s.IndexOf(",", index);
                    string s2 = s.Substring(index, index2 - index);
                    s = s.Replace(s2, "Y" + i);
                    p.replace(s2, "Y" + i);
                    i++;
                }
            }
            p.changeY2X();
            s = s.Replace("Y", "X");
        }
        bool PARALLEL = true;
        
        public ArrayList inductuion(int max_try_time)
        {
          
            resetTrainCoverage();
            predicates = new ArrayList();
            Log.log("train: " + train + "  test: " + test + "   ");
            makeHash();
            ArrayList res = new ArrayList();
            int cnt = 0;
            //phase 1: induce positive examples
            Object[] cc = trainSet.ToArray();
       
            if (PARALLEL)
            {
                Parallel.For(0, trainSet.Count, i =>
                {
                    cnt++;
                    Literal c = (Literal)cc[i];
                    Clause pred = new Clause();
                    pred.q_side = c;
                    int try_time = 0;
                    if (mode != MODE_ALLPREDICATES)
                        if(!c.visited)
                          while (try_time < max_try_time && !recursiveInduce(pred, 1,max_try_time))
                          {
                             try_time++;
                          }
                    else
                        recursiveInduce(pred, 1,max_try_time);
                });
            }
            else
            {
                foreach (Literal c in trainSet)             
                {
                    cnt++;
                    if (mode != MODE_ALLPREDICATES || !c.visited)

                    
                    {
                      Clause pred = new Clause();
                      pred.q_side = c;
                      int try_time = 0;
                      if (mode != MODE_ALLPREDICATES)
                          while (try_time < max_try_time && !recursiveInduce(pred, 1,max_try_time))
                          {
                              try_time++;                        
                          }
                      else
                          recursiveInduce(pred, 1,max_try_time);

                    }
                }
            
            }
      
            removeRedundant();
            return predicates;
        }
        public bool recursiveInduce(Clause pred, int step, int max_try_time)
        {
            bool flag = false;
            if (step > MaxSteps) return flag;
            ArrayList h = induceOnePredicate(pred, step);
            double maxScore = 0;
            Clause best = new Clause();
            foreach (Clause r in h)
            {
                if (score(r) > maxScore)
                {
                    maxScore = score(r);
                    best = r;
                }
            }
            if (maxScore > 0)
            {
                double posc;

                if (best.FullyVariable())
                {
                    posc = computeCoverage(best, true, true);
                    if (posc > 100.0 / trainSet.Count)
                    {
                        best.positiveCoverage = posc;
                        sortVariables(best);
                        predicates.Add(best);
                        flag = true;
                    }
                }
                else
                {
                    int try_time = 0;
                    flag = recursiveInduce(best, step + 1, max_try_time);
                    while (try_time < max_try_time && !flag)
                    {
                        try_time++;
                        flag = recursiveInduce(best, step + 1, max_try_time);
                    }
                }
            }
            return flag;
        }
      /*  public void addPredicate(Clause p)
        {
            predicates.Add(p);
            p.positiveCoverage = computeCoverage(p, true, false);
        }
        */
        public ArrayList induceOnePredicate(Clause pred, int step)
        {
          //  Console.WriteLine(">>>>>InduceOnePredicate  " + pred.ToString() + "step: " + step);

            ArrayList H = new ArrayList();
            if (step > MaxSteps) return H;
            HashSet<Literal> set = new HashSet<Literal>();

            ArrayList seen = new ArrayList();
            ArrayList notSeen = new ArrayList();

            foreach (string s in pred.q_side.items)
                if (!s.StartsWith("X")) notSeen.Add(s);
            foreach (Literal p in pred.getPSide())
                foreach (string s in p.items)
                    if (!s.StartsWith("X")) notSeen.Add(s);
            while (notSeen.Count > 0)
            {
                string first = (string)notSeen[0];
                notSeen.RemoveAt(0);
                seen.Add(first);
                try {
                    foreach (Literal c1 in hash.getList(first))
                    {
                        //contains: first + predicate name must be unique
                        int comparison = pred.getLastLiteral().CompareTo(c1.ToString());
                        if (c1.fact != pred.q_side.fact)// && !contains(set, first, c1.fact))
                            if(comparison <= 0)
                            { 
                                set.Add(c1);
                            }
                    }
                } catch (Exception e)
                {
                    //we have some literal in positive examples but not in background knowledge
                }
            }

            foreach (Literal p1 in set) //all subsets
            {
                Clause newp = new Clause();
                newp.q_side = pred.q_side.clone();
                foreach (Literal c in pred.getPSide())
                    newp.addPSide(c.clone());
                if (p1 != pred.q_side)
                    newp.addPSide(p1.clone());
                if(pred.replaceList != null)
                    foreach (KeyValuePair<string, string> kv in pred.replaceList.ToArray())
                        newp.replace(kv.Key, kv.Value);
                
                variablize(newp);
                newp.step = step;
            
                H.Add(newp);              
            }
        
            return H;
        }
    }
}
