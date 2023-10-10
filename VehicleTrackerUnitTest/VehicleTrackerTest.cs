using System;

namespace VehicleTrackerUnitTest
{
    [TestClass]
    public class VehicleTrackerTest
    {
        [TestMethod]
        public void VehicleTracker_GenerateSlots_Returns5nullFor5()
        {
            // Arrange
            int capacity = 5;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            // Act
            vehicleTracker.GenerateSlots();

            // Assert
            Assert.AreEqual(capacity, vehicleTracker.VehicleList.Count);
            foreach (var slot in vehicleTracker.VehicleList)
            {
                Assert.IsNull(slot.Value);
            }
        }

        [TestMethod]
        public void VehicleTracker_AddVehicle_ReturnsVehicleList3equalCar3LicenceForCar3Licence()
        {
            // Arrange
            int capacity = 5; 
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            // Act
            vehicleTracker.AddVehicle(new Vehicle("Car1Licence", true));
            vehicleTracker.AddVehicle(new Vehicle("Car2Licence", true));

            Vehicle newVehicle = new Vehicle("Car3Licence", true);
            vehicleTracker.AddVehicle(newVehicle);

            // Assert
            int expectedSlotNumber = 3;
            bool addedToExpectedSlot = vehicleTracker.VehicleList.FirstOrDefault(pair => pair.Value == newVehicle).Key == expectedSlotNumber;
            Assert.IsTrue(addedToExpectedSlot);
        }

        [TestMethod]
        public void VehicleTracker_AddVehicle_ReturnsSlotsFullMessageForCar3Licence()
        {
            // Arrange
            int capacity = 2;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            // Act
            vehicleTracker.AddVehicle(new Vehicle("Car1Licence", true));
            vehicleTracker.AddVehicle(new Vehicle("Car2Licence", true));

            try
            {
                vehicleTracker.AddVehicle(new Vehicle("Car3Licence", true));
            }
            catch (Exception ex)
            {
                // Assert
                Assert.AreEqual("Error: no slots available.", ex.Message);
                return;
            }
        }

        [TestMethod]
        public void VehicleTracker_RemoveVehicle_ReturnsVehicleList1IsNullForCar1Licence()
        {
            // Arrange
            int capacity = 3;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");
            vehicleTracker.AddVehicle(new Vehicle("Car1Licence", true));
            vehicleTracker.AddVehicle(new Vehicle("Car2Licence", true));

            // Act
            vehicleTracker.RemoveVehicle("Car1Licence");

            // Assert
            Assert.IsNull(vehicleTracker.VehicleList.FirstOrDefault(v => v.Value.Licence == "Car1Licence").Value);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void VehicleTracker_RemoveVehicle_ReturnsBadSearchMessageForInvalidLicence()
        {
            // Arrange
            int capacity = 3;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            // Act and Assert
            vehicleTracker.RemoveVehicle("InvalidLicence");
        }

        [TestMethod]
        public void VehicleTracker_RemoveVehicle_ReturnsvehicleTracker1ForSotNumber1()
        {
            // Arrange
            int capacity = 3;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");
            Vehicle vehicleToRemove = new Vehicle("Car1Licence", true);
            vehicleTracker.AddVehicle(vehicleToRemove);

            // Act
            bool removed = vehicleTracker.RemoveVehicle(1);

            // Assert
            Assert.IsTrue(removed);
            Assert.IsNull(vehicleTracker.VehicleList[1]);
        }

        [TestMethod]
        public void VehicleTracker_RemoveVehicle_ReturnsFalseForSotNumber0()
        {
            // Arrange
            int capacity = 3;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            // Act
            bool removed = vehicleTracker.RemoveVehicle(0);

            // Assert
            Assert.IsFalse(removed);
        }

        [TestMethod]
        public void VehicleTracker_RemoveVehicle_ReturnsSlotsAvailableForAddAndRemove()
        {
            // Arrange
            int capacity = 3;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            // Act
            vehicleTracker.AddVehicle(new Vehicle("Car1Licence", true));
            vehicleTracker.AddVehicle(new Vehicle("Car2Licence", true));

            // Assert
            Assert.AreEqual(1, vehicleTracker.SlotsAvailable);

            // Act
            vehicleTracker.RemoveVehicle("Car1Licence");

            // Assert
            Assert.AreEqual(2, vehicleTracker.SlotsAvailable);
        }

        [TestMethod]
        public void VehicleTracker_ParkedPassholders_ReturnsListOfPassholders()
        {
            // Arrange
            int capacity = 3;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            Vehicle passholder1 = new Vehicle("Car1Licence", true);
            Vehicle passholder2 = new Vehicle("Car2Licence", true);
            Vehicle nonPassholder = new Vehicle("Car3Licence", false);

            vehicleTracker.AddVehicle(passholder1);
            vehicleTracker.AddVehicle(passholder2);
            vehicleTracker.AddVehicle(nonPassholder);

            // Act
            List<Vehicle> passholders = vehicleTracker.ParkedPassholders();

            // Assert
            Assert.IsTrue(passholders.Contains(passholder1));
            Assert.IsTrue(passholders.Contains(passholder2));
            Assert.IsFalse(passholders.Contains(nonPassholder));
        }

        [TestMethod]
        public void VehicleTracker_PassholderPercentage_Returns40For2CarAndCapacity5()
        {
            // Arrange
            int capacity = 5;
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, "TestAddress");

            Vehicle passholder1 = new Vehicle("Car1Licence", true);
            Vehicle passholder2 = new Vehicle("Car2Licence", true);
            Vehicle nonPassholder1 = new Vehicle("Car3Licence", false);
            Vehicle nonPassholder2 = new Vehicle("Car4Licence", false);

            vehicleTracker.AddVehicle(passholder1);
            vehicleTracker.AddVehicle(passholder2);
            vehicleTracker.AddVehicle(nonPassholder1);
            vehicleTracker.AddVehicle(nonPassholder2);

            // Act
            double percentage = vehicleTracker.PassholderPercentage();

            // Assert
            Assert.AreEqual(40.0, percentage, 0.001); 
        }
    }
}