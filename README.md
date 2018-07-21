# YAD-ILP-Tool
YAD: A Learning-based Inductive Logic Programming Tool 

The tool YAD, is an implementation of a new bottom-up inductive logic learning algorithm. 
Its main purpose is to reduce learning time. This is done in such a way that in every step, in order to choose some rules that 
can create more general rules with their own combinations, instead of quite random choice, choosing is performed from a set of 
relations (rules) that have a higher chance to generate the relevant rules. Generally, its algorithm has been presented in the 
article (i.e., paper.md) as Algorithm 1.

This tool has been implemented in C# and the input parameters of YAD are as follows:

  - The percentage of Train Examples (the remaining percentage will be Test Examples percentage for testing the generated 
  generic logical rules on the data-set).

  - The number of steps (typically, it is set to the default value 4) which is used to generate a general predicate in every 
  step of induce function (inverse resolution operations) in order to produce generic logical rules. So, for example, with four 
  steps, the tool can produce general logical rules with at most four predicates in their right-hand side.

  - Try Count (typically, it is set to the default value 5) is the number of endeavors that the tool performs to create and 
  generate a general logical rule.

  - Negative Threshold (typically, it is set to a low amount, e.g. the default value 5) is the percentage of the whole negative 
  examples that every produced generic logical rule can produce negative examples equal or lower than the selected percentage, 
  otherwise, the produced logical rule is useless and it is not considered as an output generic logical rule.

## How to Use

YAD is so simple to use and there is no install instructions or guidelines to setup and install this tool. It can be executed 
in all C# IDEs, e.g. Microsoft Visual Studio, and its source code is quite available in the repository. Although there is an 
executable file (.exe file) of compiled source code as an output in the repository and obviously, it can be run itself without 
any requirements or IDEs, the source code in the repository can be even opened in a C# IDE and then, it can be recompiled and run to 
use.

Also, the functions and usage of this tool are as follows (**respectively** in use):

   1. **Open:** Opening a file (typically, a text file) consists of Background Knowledge lines (the lines should start with ‘B’ with a white-space after), Positive Examples lines (the lines should start with ‘+’ with a white-space after), and Negative Examples lines (the lines should start with ‘-’ with a white-space after) in first-order logic format as logical rules.
   
   *Due to the above instructions to open a valid and appropriate file in the tool, we have prepared a **sample** file which is* *available in the repository, of anatomical data-sets called Human and Mouse anatomies to produce some valid general logical rules in* *order to align these anatomical organs of these two different anatomies (Human and Mouse anatomies).*

   2. **Induce:** Producing general logical rules by inducing (using inverse resolution) on input background knowledge and then, the 
   generated valid logical rules with execution time (run-time) will be shown. 

   3. **Prune:** Computing the measures such as *Precision*, *Recall*, *Accuracy*, and *F-Measure* for evaluation and comparison. This step may take several minutes to be done and then computed measures will be shown.

   4. **Result Filtering:** Colorizing and filtering the results, i.e., Train and Test Examples in order to determine their coverage.

## Use Cases

This tool can be used in solving many various problems which need to discover some relationships between different phenomena. 
We previously have used this ILP tool in a prominent area of new web science called Semantic Web for Ontology Alignment (Ontology 
Mapping) problem using inductive logic programming [@Karimi2018]. We used anatomical data-sets to evaluate our new proposed approach 
for ontology alignment as a key problem in semantic web and its infrastructure using ILP by YAD. This ILP tool could generate some 
efficient generic logical rules to find some valid alignments between anatomical concepts and therefore, we could averagely achieve 
a high F-Measure with respect to acceptable percentage of Precision and Recall, among similar matching tools in 2017.

Also, the ILP tool can be used in many different problems such as bioinformatics and protein bonds analysis as well as informatics 
chemistry to discover chemical bonds. In addition, it can be used in social networks analysis and to discover the communications 
between individuals, rules, and concepts. Generally, the application of this tool is in networks analysis (networks of individuals, 
molecules, proteins, and etc.).

