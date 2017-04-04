using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basiclogic;


namespace IMS.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckInterventionState()
        {
            Approval ap = new Approval();
            string Text = ap.ChangeInterventionState("Site Engineer", "Approved", "Mosquito Net","Completed");
            Assert.AreEqual("Completed", Text);
        }
        [TestMethod]
        public void CreateIntvention()
        {

            Approval ap = new Approval();
            string Text = ap.CreateIntervention("Mosquito_net", "Joshua", "Accountant");
            Assert.AreEqual("Created", Text);
        }
    }
}
