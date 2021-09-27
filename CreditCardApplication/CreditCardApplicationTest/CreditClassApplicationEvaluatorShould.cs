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

            /*    var sut = new CreditClassApplicationEvaluator();
                var applicaton = new CreditCardApplication { GrossAnnualIncome = 100_000 };
                CreditCardApplicatonDecision decision = sut.Evalute(applicaton);
    */
        }
        [Fact]
        public void ReferYoungApplications()
        {
            var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
            mockvalidator.DefaultValue = DefaultValue.Mock;


            mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);

            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);

            var application = new CreditCardApplication { Age = 19 };

            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);
        }
        [Fact]
        public void DeclineLowincomeApllication()
        {
            Mock<IFrequentFlyerNumberValidator> validator = new Mock<IFrequentFlyerNumberValidator>();


            validator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");



            //validator.Setup(x => x.IsValid("x")).Returns(true);
            //validator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);
            //validator.Setup(x => x.IsValid(It.Is<string>(number=>number.StartsWith("y")))).
            //  Returns(true);
            /*  validator.Setup(
                  x => x.IsValid(It.IsInRange<string>("a", "z", Moq.Range.Inclusive))).Returns(true);
                        /*  validator.Setup(
                              x => x.IsValid(It.IsIn("x", "z","y"))).Returns(true);
              */
            validator.Setup(
                x => x.IsValid(It.IsRegex("[a-z]"))).Returns(true);


            var sut = new CreditClassApplicationEvaluator(validator.Object);
            var application = new CreditCardApplication
            { GrossAnnualIncome = 1000, Age = 42, FrequentFlyerNumber = "x" };
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.AutoDeclined, decision);


            /*mockvalidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");

            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);
            var application = new CreditCardApplication { GrossAnnualIncome = 19_999, Age=42,
                FrequentFlyerNumber="Ok" };
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.AutoDeclined, decision);*/
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

        //for method which conatin out attribute
        /* [Fact]
        public void DeclineLowIncomeApplicationsOutDemo() 
        {
            Mock<IFrequentFlyerNumberValidator> mockvalidator = new Mock<IFrequentFlyerNumberValidator>();

            bool isValid = true;
            mockvalidator.Setup(x => x.IsValid(It.IsAny<string>(), out isValid));
     
        
            var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);
            var application = new CreditCardApplication 
     { 
     GrossAnnualIncome = 19_999,Age=42 
     };
            CreditCardApplicatonDecision decision = sut.EvaluteusingOut(application);
            Assert.Equal(CreditCardApplicatonDecision.AutoDeclined, decision);

        }
     */
        [Fact]
        public void ReferWhenLicensExpired()
        {

            /*
                var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
                mockvalidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);

                var mockLicenseData = new Mock<IlicenseData>();
                mockLicenseData.Setup(x => x.LicenseKey).Returns("EXPIRED");

                var mockServiceinfo = new Mock<IserviceInformation>();
                mockServiceinfo.Setup(x => x.License).Returns(mockLicenseData.Object);

                var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();
                mockValidator.Setup(x => x.ServiceInformation).Returns(mockServiceinfo.Object);

            */
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();
            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("EXPIRED");

            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);
            var application = new CreditCardApplication { Age = 42 };
            CreditCardApplicatonDecision decision = sut.Evalute(application);
            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);

        }
        string GetLicenseKeyExpiryString()
        {
            return "EXPIRED";
        }
        [Fact]
        public void ValidateFrequentFlyerNumberForLowIncomeApllication()
        {
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();
            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");
            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);
            var application = new CreditCardApplication { FrequentFlyerNumber = "q" };
            sut.Evalute(application);
            mockValidator.Verify(x => x.IsValid(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void ValidateFrequentFlyerNumberForHighIncomeApllication()
        {
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();
            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");
            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);

            var application = new CreditCardApplication { GrossAnnualIncome = 100_000 };

            sut.Evalute(application);

            mockValidator.Verify(x => x.IsValid(It.IsAny<string>()), Times.Never);


        }

        [Fact]
        public void CheckLicenseKeyForLowIncomeApplication() 
        {
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();

            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");

            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);

            var application = new CreditCardApplication {GrossAnnualIncome=99_000 };
            
            sut.Evalute(application);
            
            mockValidator.VerifyGet(x => x.ServiceInformation.License.LicenseKey,Times.Never);

        }
        [Fact]
        public void SetDetailedlookupForOlderApplication()
        {
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();

            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");

            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);

            var application = new CreditCardApplication { Age=30 };

            sut.Evalute(application);

            mockValidator.VerifySet(x => x.Validationmode=It.IsAny<Validationmode>(), Times.Never);
            mockValidator.Verify(x=>x.IsValid(null),Times.Once);
            mockValidator.VerifyNoOtherCalls();

        }

        [Fact]
        public void ReferWhenFrequentFlyerValidationErroe() 
        {
            var mockValidator = new Mock<IFrequentFlyerNumberValidator>();

            mockValidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");
            mockValidator.Setup(x=>x.IsValid(It.IsAny<string>())).Throws<Exception>();

            var sut = new CreditClassApplicationEvaluator(mockValidator.Object);

            var application = new CreditCardApplication { Age=42};

             CreditCardApplicatonDecision decision=sut.Evalute(application);

            Assert.Equal(CreditCardApplicatonDecision.ReferredToHuman, decision);
        }

        /*     public void UserdetailLooKupForOlderApplications()
              {
                  var mockvalidator = new Mock<IFrequentFlyerNumberValidator>();

                  //     mockvalidator.SetupProperty(x => x.Validationmode);
                  mockvalidator.SetupAllProperties();
                  mockvalidator.Setup(x => x.ServiceInformation.License.LicenseKey).Returns("OK");

                  var sut = new CreditClassApplicationEvaluator(mockvalidator.Object);

                  var application = new CreditCardApplication { Age = 30 };

                  sut.Evalute(application);

                  Assert.Equal(Validationmode.Detailed, mockvalidator.Object.Validationmode);
              }
      */
    }
}
