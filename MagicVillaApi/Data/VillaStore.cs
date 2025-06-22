using MagicVillaApi.Models.Dto;

namespace MagicVillaApi.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
        {
                new VillaDTO() {Id=1,Name="Pool view",SqFt=100,Occupancy=4},
                new VillaDTO() {Id=2,Name="Beach view",SqFt=300,Occupancy=3}
        };
    }
}
