using Microsoft.VisualStudio.TestTools.UnitTesting;
using ПрР1_Червов;
using System;

namespace matrixUnitTast
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void check_m_4_n_5_matrix_14()
        {
            int m = 4;
            int n = 5;

            int exepted = 14;

            int actual = MatrixClass.positiveElementsCounter(m,n);

            Assert.AreEqual(exepted,actual);
        }
    }
}
