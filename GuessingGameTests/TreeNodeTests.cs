using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessingGame.data;

namespace GuessingGameTests
{
    [TestClass]
    public class TreeNodeTests
    {
        private const string ANIMAL_DOG = "Dog";
        private const string ANIMAL_PLATYPUS = "Platypus";
        private const string ANIMAL_EAGLE = "Eagle";

        private const string TRAIT_DOG = "barks";
        private const string TRAIT_PLATYPUS = "lays eggs";
        private const string TRAIT_EAGLE = "flies";

        private TreeNode node;

        [TestInitialize()]
        public void init()
        {
            node = new TreeNode(TRAIT_DOG, ANIMAL_DOG, ANIMAL_PLATYPUS);
        }

        [TestMethod]
        public void NonLeafNode_ShouldHaveTwoLeafNodes()
        {
            //node is a non leaf node
            Assert.IsFalse(node.isLeafNode());

            //and has two leaf nodes
            Assert.IsTrue(node.getYesNode().isLeafNode());
            Assert.IsTrue(node.getNoNode().isLeafNode());
        }

        [TestMethod]
        public void UpdatingALeafNode_ShoulCreateTwoLeafNodes_WithCorrectContents()
        {
            TreeNode leafNode = node.getYesNode();

            //leafNode is a leaf node
            Assert.IsTrue(leafNode.isLeafNode());
            String previouslyStoredData = leafNode.getData();

            leafNode.updateLeafNode(TRAIT_EAGLE, ANIMAL_EAGLE);

            //leafNode is no more a leaf node
            Assert.IsFalse(leafNode.isLeafNode());

            //and now shas two leaf nodes
            Assert.IsTrue(leafNode.getYesNode().isLeafNode());
            Assert.IsTrue(leafNode.getNoNode().isLeafNode());

            //its content is the new animal trait
            Assert.AreSame(leafNode.getData(), TRAIT_EAGLE);
            //its "yes" node contains the new animal
            Assert.AreSame(leafNode.getYesNode().getData(), ANIMAL_EAGLE);
            //its "no" node contains the previously stored data
            Assert.AreSame(leafNode.getNoNode().getData(), previouslyStoredData);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateNonLeafNode_ShouldThrowException()
        {
            //node is a non leaf node
            Assert.IsFalse(node.isLeafNode());
            node.updateLeafNode(TRAIT_PLATYPUS, ANIMAL_PLATYPUS);
        }
    }
}
