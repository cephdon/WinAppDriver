﻿//******************************************************************************
//
// Copyright (c) 2016 Microsoft Corporation. All rights reserved.
//
// This code is licensed under the MIT License (MIT).
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//******************************************************************************

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace W3CWebDriver
{
    [TestClass]
    public class ElementAttribute : AlarmClockBase
    {
        [TestMethod]
        public void GetValidElementAttribute()
        {
            // NOTE: HelpText is currently the only supported GetAttribute method. There are
            //       no known examples of non-null HelpText, so this should be replaced with 
            //       a different attribute once more are supported. 
            string helpText = alarmTabElement.GetAttribute("HelpText");
            Assert.AreEqual(helpText, null);
        }

        [TestMethod]
        public void GetInvalidElementAttribute()
        {
            string helpText = alarmTabElement.GetAttribute("InvalidAttribute");
            Assert.AreEqual(helpText, null);
        }
    }
}
