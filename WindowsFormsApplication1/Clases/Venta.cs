using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeGestion.Clases
{
    class Venta
    {
        Int64 id_venta;
        Int64 id_cliente;
        DateTime fecha;
        decimal total;
        Cliente c;
        string provisorio;
        int impreso;
        string venta_numero;
    
        string factura_numero;
        string observaciones;
        string tipo;
        string estado;
        decimal descuento;
        decimal iva;
        int id_fdp_1;
        int id_fdp_2;
        int id_fdp_3;
        int id_fdp_4;
        decimal fdp1_monto;
        decimal fdp2_monto;
        decimal fdp3_monto;
        decimal fdp4_monto;
        decimal en_pesos;
        public Venta() { }


        public Venta(Int64 id_venta, Int64 id_cliente, DateTime fecha, decimal total,int impreso,string venta_num, string  factura_num, string tipo, string estado,  int id_fdp_1,
        int id_fdp_2, int id_fdp_3, int id_fdp_4,  decimal fdp1_monto, decimal fdp2_monto, decimal fdp3_monto, decimal fdp4_monto, decimal decuento, decimal iva, string observa, decimal en_pesos)
        {
           
            this.fecha = fecha;
            this.id_cliente = id_cliente;
            this.id_venta = id_venta;
            this.total = total;
            this.impreso = impreso;

            this.venta_numero = venta_num;
    
            this.factura_numero = factura_num;
            this.tipo = tipo;
            this.estado = estado;
            this.id_fdp_1 = id_fdp_1;
            this.id_fdp_2 = id_fdp_2;
            this.id_fdp_3 = id_fdp_3;
            this.id_fdp_4 = id_fdp_4;
            this.fdp1_monto = fdp1_monto;
            this.fdp2_monto = fdp2_monto;
            this.fdp3_monto = fdp3_monto;
            this.fdp4_monto = fdp4_monto;
            this.descuento = decuento;
            this.iva = iva;
            this.observaciones = observa;
            this.en_pesos = en_pesos;
        }
        public string Venta_numero
        {
            get { return venta_numero; }
            set { venta_numero = value; }
        }

        public string Factura_numero
        {
            get { return factura_numero; }
            set { factura_numero = value; }
        }
        public string Provisorio
        {
            get { return provisorio; }
            set { provisorio = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Int64 Id_venta
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        public int Impreso
        {
            get { return impreso; }
            set { impreso = value; }
        }
        public Int64 Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public Cliente Clientes
        {
            get { return c; }
            set { c = value; }
        }

        public int Id_fdp_1
        {
            get { return id_fdp_1; }
            set { id_fdp_1 = value; }

        }
        public int Id_fdp_2
        {
            get { return id_fdp_2; }
            set { id_fdp_2 = value; }

        }
        public int Id_fdp_3
        {
            get { return id_fdp_3; }
            set { id_fdp_3 = value; }

        }
        public int Id_fdp_4
        {
            get { return id_fdp_4; }
            set { id_fdp_4 = value; }

        }
        public decimal Fdp1_monto
        {
            get { return fdp1_monto; }
            set { fdp1_monto = value; }
        }
        public decimal Fdp2_monto
        {
            get { return fdp2_monto; }
            set { fdp2_monto = value; }
        }
        public decimal Fdp3_monto
        {
            get { return fdp3_monto; }
            set { fdp3_monto = value; }
        }
        public decimal Fdp4_monto
        {
            get { return fdp4_monto; }
            set { fdp4_monto = value; }
        }
        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
            public decimal En_pesos
        {
            get { return en_pesos; }
            set { en_pesos = value; }
        }
        public decimal Iva
        {
            get { return iva; }
            set { iva= value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
    }
}