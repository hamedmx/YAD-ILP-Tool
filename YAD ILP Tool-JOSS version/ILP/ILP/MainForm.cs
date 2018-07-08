using SbsSW.SwiPlCs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILP
{
 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            modeCB.SelectedIndex = 1;    
        }
        string[] bs;
        string[] ps;
        string[] ns;
        public void initForInd()
        {
            
            bs = new string[bkLB.Items.Count];
            ps = new string[pos.Items.Count];
            ns = new string[negLB.Items.Count];
            int i = 0;
            foreach (string s1 in bkLB.Items)
            {
                bs[i] = s1;
                i++;
             //   if (i > 600)
               //    break;
            }
            bkTab.Text = "Background Knowledge" + "("+i+")";
            i = 0;


            foreach (string s1 in pos.Items)
            {
                ps[i] = s1;
                i++;
               // if (i > Int32.Parse(Tedad.Text)) 
            //       break;
            }
            posTab.Text = "Positive Examples" + "(" + i + ")";

            i = 0;
            foreach (string s1 in negLB.Items)
            {
                ns[i] = s1;
                i++;
            }
            negTab.Text = "Negative Examples" + "(" + i + ")";

        }
        InductionEngine ind = new InductionEngine();
        //ArrayList positives = new ArrayList();
        int Max_Try_Cnt = 1;
        private void InductionBtn_Click(object sender, EventArgs e) //induce
        {
         
        }
        ArrayList preds;
        private void showResults(ArrayList preds)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Predicate");
            dt.Columns.Add("Positive Coverage");
            dt.Columns.Add("Negative Coverage");
            dt.Columns.Add("Step");

            for (int k = 0; k < preds.Count; k++)
            {
                dt.Rows.Add(preds);
                dt.Rows[k]["Predicate"] = ((Clause)preds[k]).ToString();
                dt.Rows[k]["Positive Coverage"] = ((Clause)preds[k]).positiveCoverage;
                dt.Rows[k]["Negative Coverage"] = ((Clause)preds[k]).negativeCoverage;
                dt.Rows[k]["Step"] = ((Clause)preds[k]).step;
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            ArrayList trainList = ind.getTrainSet();
            ArrayList testList = ind.getTestSet();
            //fill grid of positive examples
            DataTable trainDT = new DataTable();
            trainDT.Columns.Add("Positive Example");
            trainDT.Columns.Add("Coverage");
            //    trainDT.Columns.Add("Train/Test");
            DataTable testDT = new DataTable();
            testDT.Columns.Add("Positive Example");
            testDT.Columns.Add("Coverage");
            // testDT.Columns.Add("Train/Test");
            // int j = 0;int t = 0;
            for (int k = 0; k < trainList.Count; k++)
            {
                DataRow dr = trainDT.NewRow();
                dr["Positive Example"] = ((Literal)trainList[k]).ToString();
                dr["Coverage"] = ((Literal)trainList[k]).covered;
                trainDT.Rows.Add(dr);
            }
            for (int k = 0; k < testList.Count; k++)
            {
                DataRow dr = testDT.NewRow();
                dr["Positive Example"] = ((Literal)testList[k]).ToString();
                dr["Coverage"] = ((Literal)testList[k]).covered;
                testDT.Rows.Add(dr);


            }
            //  positiveGrid.DataSource = dt2;
            trainGrid.DataSource = trainDT;
            testGrid.DataSource = testDT;
            trainGrid.Refresh();
            testGrid.Refresh();


        }
    //    ArrayList pos = new ArrayList();

        private void loadBtn_Click(object sender, EventArgs e)
        {

        }

        /*
                private void SimulBtn_Click(object sender, EventArgs e)
                {
                    initForInd();
                    InductionEngine ind = new InductionEngine();
                    //ind.trainPercent = (int)trainUD.Value;
                    int fromStep = (int)stepUD.Value;
                    int toStep = (int)step2UD.Value;
                    //ind.MaxSteps = (int)stepUD.Value;

                    ind.setPosThresh((double)posThresh.Value);
                    ind.setNegThresh((double)negThresh.Value);
              //      string target = targetTB.Text;


                    ind.makeBackground(bs);
                    ind.makeNegatives(ns);
                    for (int step = fromStep; step <= toStep; step++)
                    {
                        ind.MaxSteps = step;
                        for (int percent = 10; percent < 100; percent = percent + 10)
                        {
                            ind.trainPercent = percent;
                            for (int iter = 1; iter <= 2; iter++)
                            {
                                ind.makePositives(ps);
                                DateTime startTime = DateTime.Now;
                                Log.line();
                                Log.log(step + " " + percent + " " + iter + " ");


                                ArrayList preds = ind.inductuion(variableCB.Checked);
                                DateTime endTime = DateTime.Now;

                                long mili = endTime.Subtract(startTime).Ticks / 10000;
                                for (int jj = step; jj <= 5; jj++)
                                    Log.log(" " + 0);
                                Log.log("  time: " + mili);
                                label2.Text = mili.ToString();
                                double dr = ind.computeDetectionRate();
                                DRLbl.Text = dr.ToString();
                                Log.log("  dr: " + dr);
                                Log.log("  rules: " + ind.numberOfRules());
                            }
                        }
                    }
                }
          */
        private void FilterBtn_Click(object sender, EventArgs e)
        {
        
            /*       double recall = 0;
                   double percision = 0;

                   ind.computeDetectionRate(preds, ref recall, ref percision);
                   double fmeasure = 0;
                   if(recall + percision  != 0)
                       fmeasure = 2 * recall * percision / (recall + percision);

                   DRLbl.Text = recall.ToString();
                   percLbl.Text = percision.ToString();
                   fmeasureLbl.Text = fmeasure.ToString();
                   showResults(preds);
                   */
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
          
        }

        //private void saveBtn_Click(object sender, EventArgs e)
        //{
        //    StreamWriter sw = new StreamWriter("result.txt",true);
        //    if (preds != null)
        //        foreach (Clause p in preds)
        //            if (p.positiveCoverage > 5)
        //            {
        //                sw.Write(p.ToString() + Environment.NewLine);
        //            }
        //    sw.Close();
        //}

        private void LoadResultBtn_Click(object sender, EventArgs e)
        {
           /* System.IO.StreamReader fs = new System.IO.StreamReader("result.txt");


            while (!fs.EndOfStream)
            {
                string s = fs.ReadLine();
                if (s != null && s != "")
                {
                    Clause p = new Clause(s);
                    ind.addPredicate(p);
                }
            }
            fs.Close();
            */
        }

        private void deleteResultBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("result.txt");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*DateTime startTime = DateTime.Now;
            bool variablized = variableCB.Checked;
            Log.line();
            preds = ind.inductuion( Max_Try_Cnt);
            DateTime endTime = DateTime.Now;
            showResults(preds);
            long mili = endTime.Subtract(startTime).Ticks / 10000;
            Log.log("  time: " + mili);
            label2.Text = mili.ToString();
            */
        }

        private void pruneBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void variableCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void posThresh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAD is inducing and producing general logical rules...\nThis may take several minutes.\nBe patient...",
                "YAD Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            initForInd();
            Max_Try_Cnt = Int32.Parse(TryCnt.Text);
            ind.trainPercent = (int)trainUD.Value;
            ind.MaxSteps = (int)Step3UD.Value;
            int _mode = modeCB.SelectedIndex;
            if (_mode == -1) _mode = 0;

            ind.mode = _mode;

         //   ind.setPosThresh((double)posThresh.Value);
            ind.setNegThresh((double)negThresh.Value);
            //string target = targetTB.Text;
            ind.makeBackground(bs);
            ind.makeNegatives(ns);
            //   ps = new string[1];
            // ps[0] = "align(nci_c12234,ma_0001588)";
            ind.makePositives(ps);

            DateTime startTime = DateTime.Now;
        //    bool variablized = variableCB.Checked;
            Log.line();
            preds = ind.inductuion(Max_Try_Cnt);
            DateTime endTime = DateTime.Now;
            showResults(preds);
            long mili = endTime.Subtract(startTime).Ticks / 10000;
            Log.log("  time: " + mili);
            label2.Text = mili.ToString();
            //   double dr = 0;
            // dr = ind.computeDetectionRate();
            //DRLbl.Text = dr.ToString();
            // Log.log("  dr: " + dr);
            // Log.log("  rules: " + ind.numberOfRules());
            showResults(preds);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void modeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                System.IO.StreamReader fs = new System.IO.StreamReader(openFileDialog1.FileName);//,System.IO.FileMode.Open);
                //posLB.Items.Clear();
                pos.Items.Clear();
                negLB.Items.Clear();
                bkLB.Items.Clear();
                while (!fs.EndOfStream)
                {
                    string s = fs.ReadLine();
                    if (s != null && s != "")
                    {
                        if (s.StartsWith("+"))
                            pos.Items.Add(s.Substring(1));
                        if (s.StartsWith("-"))
                            negLB.Items.Add(s.Substring(1));
                        if (s.StartsWith("B"))
                            bkLB.Items.Add(s.Substring(1));
                    }

                }

                fs.Close();
            }

        }

        private void pruneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAD is pruning and computing the measurements...\nThis may take several minutes.\nBe patient...",
             "YAD Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            double recall = 0;
            double percision = 0;
            double fmeasure = 0;
            double accuracy = 0;

            ind.setNegThresh((double)negThresh.Value);
            preds = ind.prune(ref recall, ref percision, ref fmeasure, ref accuracy);

            DRLbl.Text = recall.ToString();
            percLbl.Text = percision.ToString();
            fmeasureLbl.Text = fmeasure.ToString();
            accuracyValLBL.Text = accuracy.ToString();
            showResults(preds);
        }

        private void colorizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  int x = 1000;
            int temp = 0;
            Parallel.For(0, x, i =>
            {
                for (int j = 0; j < 5000; j++)
                {
                    
                    for (int k = 0; k < 5000; k++)
                    {
                        temp = j * k;
                       // Console.WriteLine(i+" "+j+" "+k);
                    }
                   
                }
            });
            Console.WriteLine("**"+temp);
            */
            foreach (DataGridViewRow row in trainGrid.Rows)
                if ((string)row.Cells[1].Value == "True")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                    row.DefaultCellStyle.BackColor = Color.Red;

            trainGrid.Refresh();
            foreach (DataGridViewRow row in testGrid.Rows)
                if ((string)row.Cells[1].Value == "True")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                    row.DefaultCellStyle.BackColor = Color.Red;

            testGrid.Refresh();
        }

        private void Step3UD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trainUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void posTab_Click(object sender, EventArgs e)
        {

        }

        private void negLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bkLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void TryCnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void negThresh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}