using EfRegistration;
using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Mappers
{
    public class BuildingMapper
    {
        public static BuildingDAO MapToBuildingDAO(Building building)
        {
            var build = new BuildingDAO();
            build.Id = building.BuildingID;
            build.Name = building.BuildingName;

            return build;
        }

        public static Building MapToBuilding(BuildingDAO building)
        {
            var build = new Building();
            build.BuildingID = building.Id;
            build.BuildingName = building.Name;

            return build;
        }
    }
}
