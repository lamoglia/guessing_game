using System;

namespace GuessingGame.data
{
    public class TreeNode
    {
        private String data;
        private TreeNode yesNode;
        private TreeNode noNode;

        /// <summary>
        /// Creates a leaf node with contents being the informed parameter.
        /// </summary>
        /// <param name="animalName">An animal name</param>
        private TreeNode(String animalName)
        {
            data = animalName;
        }

        /// <summary>
        /// Creates a node with a trait and two leaf nodes, each one containing a name of an animal.
        /// </summary>
        /// <param name="trait"></param>
        /// <param name="animalWithTrait"></param>
        /// <param name="animalWithoutTrait"></param>
        public TreeNode(String trait, String animalWithTrait, String animalWithoutTrait)
        {
            data = trait;
            yesNode = new TreeNode(animalWithTrait);
            noNode = new TreeNode(animalWithoutTrait);
        }

        /// <summary>
        /// Transforms the leaf node in a non-leaf node. 
        /// Its previous content are stored in the created "no" child node, 
        /// its content get changed to the trait of the animal stored in the created "yes" child node.
        /// </summary>
        /// <param name="newAnimalTrait">An animal trait</param>
        /// <param name="newAnimalName">An animal name</param>
        public void updateLeafNode(string newAnimalTrait, string newAnimalName)
        {
            if (!isLeafNode())
            {   
                //Updating non-leaf node can cause data loss.
                throw new Exception("Can't update a non-leaf node.");
            }

            noNode = new TreeNode(data);
            yesNode = new TreeNode(newAnimalName);
            data = newAnimalTrait;
        }

        public TreeNode getNoNode()
        {
            return noNode;
        }

        public TreeNode getYesNode()
        {
            return yesNode;
        }

        public String getData()
        {
            return data;
        }

        public Boolean isLeafNode()
        {
            return yesNode == null && noNode == null;
        }
    }
}
