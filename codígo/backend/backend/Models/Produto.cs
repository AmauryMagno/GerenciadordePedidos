﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar um nome!")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma descrição!")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar um valor!")]
        [Display(Name = "Preço")]
        public double valor { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma categoria!")]
        [Display(Name = "Categoria")]
        public string categoria { get; set; }

        [Required(ErrorMessage = "É obrigatório adicionar uma imagem!")]
        [Display(Name = "Imagem")]
        public  byte[] imagem { get; set; }

    }
}
