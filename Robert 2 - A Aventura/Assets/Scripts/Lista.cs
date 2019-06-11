using System.Collections;
using System.Collections.Generic;

public class Lista<T>
{
    public partial class Node<T>
    {
        public T Valor { get; set; }
        public Node<T> Esq { get; set; }
        public Node<T> Dir { get; set; }
        public Node(T valor)
        {
            this.Valor = valor;
            Esq = null;
            Dir = null;
        }
    }
    private Node<T> P;
    private int Tamanho { get; set; }
    public bool teste = true;
    public bool EstaVazia
    {
        get { return P == null; }
    }
    public int TamanhoLista
    {
        get { return Tamanho; }
    }
    public Lista()
    {
        P = null;
        Tamanho = 0;
    }
    public void Insere(T valor)
    {
        Node<T> node = new Node<T>(valor);
        node.Dir = P;
        if (P != null)
            P.Esq = node;
        P = node;
        Tamanho++;
    }
    public bool EstaNaLista(T valor)
    {
        Node<T> Aux = P;
        while (Aux != null && !EqualityComparer<T>.Default.Equals(Aux.Valor, valor))
        {
            Aux = Aux.Dir;
        }
        if (Aux == null)
            return false;
        return true;
    }
    public bool Remove(T valor)
    {
        Node<T> Aux = P;
        if (!EstaNaLista(valor))
            return false;
        while (!EqualityComparer<T>.Default.Equals(Aux.Valor, valor))
        {
            Aux = Aux.Dir;
        }
        if (Aux.Esq != null)
        {
            Aux.Esq.Dir = Aux.Dir;
            if (Aux.Dir != null)
                Aux.Dir.Esq = Aux.Esq;
        }
        else
        {
            P = Aux.Dir;
            if (P != null)
                P.Esq = null;
        }
        Tamanho--;
        return true;
    }
}
