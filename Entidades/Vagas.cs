﻿namespace Estacionamento.Entidades
{
    public class Vagas
    {
        public Vagas() { }

        public int Id { get; set; }
        public string Sigla { get; set; }
        public Veiculos veiculo { get; set; }
        public string Status { get; set; }
    }
}