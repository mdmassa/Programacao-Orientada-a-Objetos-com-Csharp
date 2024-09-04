using System;

class Animal {
    public string nome;
    public double peso;

    public Animal(string nome, double peso) {
        this.nome = nome;
        this.peso = peso;
    }

    public virtual void Locomover() {
        Console.WriteLine($"O {nome} se locomove de forma padrão.");
    }
}