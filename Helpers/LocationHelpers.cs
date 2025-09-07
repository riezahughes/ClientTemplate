using Archipelago.Core;
using Archipelago.Core.Models;

namespace Helpers
{
    public class LocationHelpers
    {
        public static List<ILocation> BuildLocationList(Dictionary<string, object> options)
        {
            List<ILocation> locations = new List<ILocation>();

            List<ILocation> conditionalChoice = new List<ILocation>();

            conditionalChoice.Add(new Location()
            {
                Id = -1,
                Name = "Cleared Level",
                Address = 0x000,
                CheckType = LocationCheckType.Bit,
                AddressBit = 4
            });
            CompositeLocation location = new CompositeLocation()
            {
                Name = "test",
                Id = 111,
                CheckType = LocationCheckType.AND,
                Conditions = conditionalChoice
            };

            // ulong currentGameStatus = Memory.ReadUInt(Addresses.InGameCheck);
            // TODO: check values in here against the game
            locations.Add(location);
            return locations;
        }
    }
}