//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Zoologico {
    Animal jaula[] = new Animal[10];
    
    public void acaoZoologico(){
        jaula[0] = new Cachorro();
        jaula[1] = new Cavalo();
        jaula[2] = new Preguica();
        jaula[3] = new Gato();
        jaula[4] = new Coelho();
        jaula[5] = new Macaco();
        jaula[6] = new Coelho();
        jaula[7] = new Gato();
        jaula[8] = new Preguica();
        jaula[9] = new Cavalo();
    
        for(int i = 0; i < jaula.length; i++){
            jaula[i].emitirSom();
            jaula[i].locomocao();
        }
    }

}
