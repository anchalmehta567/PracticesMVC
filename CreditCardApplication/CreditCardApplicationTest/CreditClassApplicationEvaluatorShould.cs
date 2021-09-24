using CreditCardApplications;
using System;
using Xunit;
using CreditCardApplications;
using Moq;
namespace CreditCardApplicationTest
{
    public class CreditClassApplicationEvaluatorShould  
    {
        [Fact]
        public void AcceptHighIncomeApplication()
        {
            Mock<IFrequentFlyerNumberValidator> mockvalidator = new Mock<IFrequentFlyerNumberValidator>();

            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);
            var application = new CreditCardApplication { GrossAnnualIncome = 100_000 };
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.AutoAccepted, decision);
        }
        [Fact]
        public void ReferYoungApplications() 
        {
            var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
            mockvalidator.DefaultValue = DefaultValue.Mock;


            mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);
            
            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);
            
            var application = new CreditCardApplication { Age=19};
            
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);
        }
        [Fact]
        public void DeclineLowincomeApllication() 
        {

            Mock<IFrequentFlyerNumberValidator> mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
            //    mockvalidator.Setup(x => x.IsValid("x")).Returns(true);
            //  mockvalidator.Setup(x => x.IsValid(It.IsAny<String>())).Returns(true);
            /*mockvalidator.Setup(
                x => x.IsValid(It.Is<String>(number=>number.StartsWith("y")))).Returns(true);
*/
            /*mockvalidator.Setup(
                x => x.IsValid(It.IsInRange<String>("a" ,"z",Moq.Range.Inclusive))).Returns(true);
*/
            /*mockvalidator.Setup(
                x => x.IsValid(It.IsIn<String>("z", "y","x"))).Returns(true);
*/
            /*mockvalidator.Setup(
                x => x.IsValid(It.IsRegex("[a-z]"))).Returns(true);
*/
            mockvalidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");

            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);
            var application = new CreditCardApplication { GrossAnnualIncome = 19_999, Age=42,
                FrequentFlyerNumber="Ok" };
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.AutoDeclined, decision);
        }
        [Fact]
        public void RefervalidFrequentApllications() 
        {
            Mock<IFrequentFlyerNumberValidator> mockvalidator 
                = new Mock<IFrequentFlyerNumberValidator>();

            mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(false);
            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);

            var application = new CreditCardApplication();
           CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);
        }
        [Fact]
        public void ReferInvalidFrequentApllications() 
        {
            Mock<IFrequentFlyerNumberValidator> mockvalidator
                = new Mock<IFrequentFlyerNumberValidator>();
            mockvalidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");

            mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);
          //  mockvalidator.Setup(x => x.LicenseKey).Returns("EXPIRED");

            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);

            var application = new CreditCardApplication();
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);
        }
     /* [Fact]
        public void DeclineLowIncomeApplicationsOutDemo() 
        {
            Mock<IFrequentFlyerNumberValidator> mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
            bool isValid = true;
            mockvalidator.Setup(x => x.IsValid(It.IsAny<string>(), out isValid));
            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);
            var application = new CreditCardApplication { GrossAnnualIncome = 19_999,Age=42 };
            CreditCardApplicatonDecision decision = sut.EvaluteusingOut(application);
            Assert.Equal(CreditCardApplicatonDecision.AutoDeclined, decision);

        }
     */  
        [Fact]
        public void ReferWhenLicensExpired() 
        {

            /*
              //          var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
                //        mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);
                        var mockLicenseData = new Mock<IlicenseData>();
                        mockLicenseData.Setup(x => x.LicenseKey).Returns("EXPIRED");
                        // mockvalidator.Setup(x => x.LicenseKey).Returns(GetLicenseKeyExpiryString);
                        var mockServiceinfo = new Mock<IserviceInformation>();
                        mockServiceinfo.Setup(x => x.License).Returns(mockLicenseData.Object);
                        var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
                        mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);
                        var mockValidator = new Mock<IFrequentFlyerNumberValidator>();
                        mockValidator.Setup(x => x.ServiceInformation).Returns(mockServiceinfo.Object);
            */
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();
            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("EXPIRED");

            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);
            var application = new CreditCardApplication {  Age = 42 };
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);

        }
        string GetLicenseKeyExpiryString()
        {
            return "EXPIRED";
        }
    }
}
