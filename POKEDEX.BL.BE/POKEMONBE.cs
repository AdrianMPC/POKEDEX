using System;
namespace POKEDEX.BL.BE
{
    public class POKEMONBE
    {
        public int POKEMONID{ get; set; }
        public string? NAME { get; set; }
        public int TYPE1 { get; set; }
        public string? TYPEs1 { get; set; }
        public int TYPE2 { get; set; }
        public string? TYPEs2 { get; set; }
        public int HP { get; set; }
        public int ATTACK { get; set; }
        public int DEFENSE { get; set; }
        public int SPEED_ATTACK { get; set; }
        public int SPEED_DEFENSE { get; set; }
        public int SPEED { get; set; }
        public string? IMAGE_DIR { get; set; }
        public string? STATE { get; set; }

    }
}