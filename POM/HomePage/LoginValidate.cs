﻿using System;
using NUnit.Framework;
using AutomationFrameWork.Base;
using AutomationFrameWork.ActionsKeys;
using System.Threading;

namespace AutomationFrameWork.POM.HomePage
{
    class LoginValidate : BaseWebValidation<LoginElement> 
    {        
        public void validateLoginSucesfully(string expected)
        {
            WebKeywords.Instance.WaitTitleContains(expected,30);    
            string check = WebKeywords.Instance.GetTitle();
            Assert.IsTrue(check.Contains(expected), "Actual [" + check + "] is not match with expected [" + expected + "]");
        }
        public void validateUserNameErrorMsg(string expected)
        {
            WebKeywords.Instance.WaitElementVisible(Element.waitLblErrorUserMsg, 30);          
            Assert.IsTrue(WebKeywords.Instance.GetAttribute(Element.lblErrorUserMsg, "innerHTML").Equals(expected), "Actual ["+ WebKeywords.Instance.GetAttribute(Element.lblErrorUserMsg, "innerHTML") + "] is not match with expected ["+expected+"]");
        }
        public void validatePassErrorMsg(string expected)
        {
            WebKeywords.Instance.WaitElementVisible(Element.waitLblErrorPassMsg, 30);
            Assert.IsTrue(WebKeywords.Instance.GetAttribute(Element.lblErrorPassMsg, "innerText").Equals(expected), "Actual [" + WebKeywords.Instance.GetAttribute(Element.lblErrorPassMsg, "innerText") + "] is not match with expected [" + expected + "]");
        }       
    }
}
