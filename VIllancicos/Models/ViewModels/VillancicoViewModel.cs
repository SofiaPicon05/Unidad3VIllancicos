﻿namespace VIllancicos.Models.ViewModels
{
    public class VillancicoViewModel
    {
        public string Nombre { get; set; } = null!;
        public string Compositor { get; set; } = null!;
        public int Año { get; set; }
        public string Letra { get; set; } = null!;
        public string URL { get; set; } = null!;
    }

}
