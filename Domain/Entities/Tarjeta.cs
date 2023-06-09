﻿namespace Domain.Entities
{
    public class Tarjeta
    {
        public Guid TarjetaId { get; set; }
        public string NumeroTarjeta { get; set; }
        public string TipoTarjeta { get; set; }
        public DateTime Vencimiento { get; set; }
        public string EntidadTarjeta { get; set; }

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}