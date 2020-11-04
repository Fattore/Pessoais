//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Macaco extends Animal {

    @Override
    public void emitirSom() {
        System.out.println("Uh Ah Ah!!");
    }

    @Override
    public void locomocao() {
        System.out.println("Macaco se pendurando...");
    }
    
    public Macaco(){};
    
    public Macaco(String nome, int idade){
        this.nome = nome;
        this.idade = idade;
        this.nome = "Macaco";
    }         
}
