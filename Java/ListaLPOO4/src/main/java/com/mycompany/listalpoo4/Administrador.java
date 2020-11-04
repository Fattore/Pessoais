//Murilo Gomes de Fattore e Brito
//F03HBG-3
package com.mycompany.listalpoo4;

public class Administrador extends Empregado {
    private double ajudaDeCusto;
    
    public void setAjudaCusto(double AJCusto){
        this.ajudaDeCusto = AJCusto;
    }
    
    public double getAjudaCusto(){
        return ajudaDeCusto;
    }
    
    @Override
    public double calcularSalario(){
        return getAjudaCusto() + super.calcularSalario();
    }    
}
