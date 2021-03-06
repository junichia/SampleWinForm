// <copyright file="Form1Test.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWinForm;

namespace SampleWinForm.Tests
{
    /// <summary>このクラスには、Form1 に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(Form1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Form1Test
    {
        /// <summary>.ctor() のテスト スタブ </summary>
        [PexMethod]
        public Form1 ConstructorTest()
        {
            Form1 target = new Form1();
            return target;
            // TODO: アサーションを メソッド Form1Test.ConstructorTest() に追加します
        }
    }
}
