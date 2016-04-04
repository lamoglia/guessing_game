using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessingGame.data;

namespace GuessingGameTests
{
    [TestClass]
    public class TreeTests
    {
        private const string ANIMAL_DOG = "Dog";
        private const string ANIMAL_PLATYPUS = "Platypus";

        private const string TRAIT_DOG = "barks";
        private const string TRAIT_PLATYPUS = "lays eggs";

        private Tree tree;

        [TestInitialize()]
        public void init()
        {
            tree = new Tree(TRAIT_DOG, ANIMAL_DOG, ANIMAL_PLATYPUS);
        }

        [TestMethod]
        public void ANewTree_shouldHaveARootNodeWithTwoLeaves()
        {
            Assert.IsFalse(tree.getRootNode().isLeafNode());

            Assert.IsTrue(tree.getRootNode().getYesNode().isLeafNode());
            Assert.IsTrue(tree.getRootNode().getNoNode().isLeafNode());
        }

        [TestMethod]
        public void ANewTree_shouldHaveARootNode_withTheAnimalWithoutTheTraitStoredOnItsNoNode()
        {
            Assert.IsFalse(tree.getRootNode().isLeafNode());
            Assert.AreSame(tree.getRootNode().getNoNode().getData(), ANIMAL_PLATYPUS);
        }

        [TestMethod]
        public void ANewTree_shouldHaveARootNode_withTheTraitOfTheAnimalStoredOnItsYesNode()
        {
            Assert.AreSame(tree.getRootNode().getData(), TRAIT_DOG);
            Assert.AreSame(tree.getRootNode().getYesNode().getData(), ANIMAL_DOG);
        }
    }
}
