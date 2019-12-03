using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// save warehouse dimensions
// save item name
// save item size
// output total space
// output space remaining
// add item
// delete item
// error for insufficient space
// view item list
// clear item list
// view render
// items saved in a list
namespace Tests
{
    public class NewTestScript
    {
        // make a test Item
        // name, height, width, length, quantity
        //Gamemanager game = new Gamemanager();
        Gamemanager game;
        //Item crate = new Item("crate", 1, 1, 1, 1);
        
        // A Test behaves as an ordinary method
        [Test]
        public void WarehouseDimension()
        {
            // make a gamemanager for testing
            // Gamemanager game = new Gamemanager();
            //Gamemanager._instance = game;
            // fill a warehouse
            //Gamemanager._instance.warehouse3D = new string[3,3,3];
            Assert.IsTrue(true);
            // Use the Assert class to test conditions
        }

        [Test]
        public void ItemName()
        {
            //GameObject gm = new GameObject();
            Assert.IsTrue(true);
        }

        [Test]
        public void ItemSize()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void OutputSpace()
        {
            Assert.IsTrue(true);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void CheckInputBound()
        {
            // Assert

        }

        [Test]
        public void Clear()
        {
        }

        [Test]
        public void AddItem()
        {
            // Gamemanager game = new Gamemanager();
            // game.addItemToList(crate);
            Assert.IsTrue(true);
        }
        [Test]
        public void DeleteItem()
        {
            // game.DeleteItemFrom3D(crate.Name);
            Assert.IsTrue(true);
        }
    }
}
