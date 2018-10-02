class Transferencia : Pedido
{
    //Construtores
    public Transferencia() {

    }

    public Transferencia(long id_pedido, TEstado estado)
    {
		Id_pedido = id_pedido;
		Estado = estado;
    }
}

