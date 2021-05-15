using Accord.MachineLearning;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class MachineLearning
    {
        void Learn()
        {
            string[] texts =
                 {
    @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas molestie malesuada 
      nisi et placerat. Curabitur blandit porttitor suscipit. Nunc facilisis ultrices felis,
      vitae luctus arcu semper in. Fusce ut felis ipsum. Sed faucibus tortor ut felis placerat
      euismod. Vestibulum pharetra velit et dolor ornare quis malesuada leo aliquam. Aenean 
      lobortis, tortor iaculis vestibulum dictum, tellus nisi vestibulum libero, ultricies 
      pretium nisi ante in neque. Integer et massa lectus. Aenean ut sem quam. Mauris at nisl 
      augue, volutpat tempus nisl. Suspendisse luctus convallis metus, vitae pretium risus 
      pretium vitae. Duis tristique euismod aliquam",

    @"Sed consectetur nisl et diam mattis varius. Aliquam ornare tincidunt arcu eget adipiscing. 
      Etiam quis augue lectus, vel sollicitudin lorem. Fusce lacinia, leo non porttitor adipiscing, 
      mauris purus lobortis ipsum, id scelerisque erat neque eget nunc. Suspendisse potenti. Etiam 
      non urna non libero pulvinar consequat ac vitae turpis. Nam urna eros, laoreet id sagittis eu,
      posuere in sapien. Phasellus semper convallis faucibus. Nulla fermentum faucibus tellus in 
      rutrum. Maecenas quis risus augue, eu gravida massa."
};
            string[][] words = texts.Tokenize();

            // Create a new TF-IDF with options:
            var codebook = new TFIDF()
            {
                Tf = TermFrequency.Log,
                Idf = InverseDocumentFrequency.Default
            };

            // Compute the codebook (note: this would have to be done only for the training set)
            codebook.Learn(words);


            // Now, we can use the learned codebook to extract fixed-length
            // representations of the different texts (paragraphs) above:

            // Extract a feature vector from the text 1:
            double[] bow1 = codebook.Transform(words[0]);

            // Extract a feature vector from the text 2:
            double[] bow2 = codebook.Transform(words[1]);

            // we could also have transformed everything at once, i.e.
            // double[][] bow = codebook.Transform(words);


            // Now, since we have finite length representations (both bow1 and bow2 should
            // have the same size), we can pass them to any classifier or machine learning
            // method. For example, we can pass them to a Logistic Regression Classifier to
            // discern between the first and second paragraphs

            // Lets create a Logistic classifier to separate the two paragraphs:
            var learner = new IterativeReweightedLeastSquares<LogisticRegression>()
            {
                Tolerance = 1e-4,  // Let's set some convergence parameters
                MaxIterations = 100,  // maximum number of iterations to perform
                Regularization = 0
            };

            // Now, we use the learning algorithm to learn the distinction between the two:
            LogisticRegression reg = learner.Learn(new[] { bow1, bow2 }, new[] { false, true });

            // Finally, we can predict using the classifier:
            bool c1 = reg.Decide(bow1); // Should be false
            bool c2 = reg.Decide(bow2); // Should be true
        }
    }
}
