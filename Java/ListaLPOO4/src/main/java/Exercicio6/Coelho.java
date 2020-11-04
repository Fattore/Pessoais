//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Coelho extends Animal{

    @Override
    public void emitirSom() {
        System.out.println("Sniff!!");
    }

    @Override
    public void locomocao() {
        System.out.println("Coelho pulando...");
    }
    
    public Coelho(){};
    
    public Coelho(String nome, int idade){
        this.nome = nome;
        this.idade = idade;
        this.nome = "Coelho";
    }       
}
