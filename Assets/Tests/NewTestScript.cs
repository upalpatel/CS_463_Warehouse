using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class NewTestScript
    {
        // make a gamemanager for testing
        Gamemanager game = new Gamemanager();
        // make a test Item
        // name, height, width, length, quantity
        Item crate = new Item("crate", 1, 1, 1, 1);


        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
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
            GameObject gameobject;
            gameobject = new GameObject();
        }
        [Test]
        public void ValidRender()
        {
            //
        }
        [Test]
        public void PackingTest()
        {

        }
        [Test]
        public void AddItem()
        {

        }
        [Test]
        public void DeleteItem()
        {
            
        }
    }
}
