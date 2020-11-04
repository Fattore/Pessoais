//Murilo Gomes de Fattore e Brito
//F03HBG-3
package com.mycompany.listalpoo4;

public class Empregado extends Pessoa {
    private int codigoSetor;
    private double salarioBase;
    private double imposto;
    
    public void setCodigoSetor(int CODSetor){
        this.codigoSetor = CODSetor;
    }
    
    public int getCodigoSetor(){
        return this.codigoSetor;
    }
    
    public void setSalarioBase(double SALBase){
        this.salarioBase = SALBase;
    }
    
    public double getSalarioBase(){
        return salarioBase;
    }

    public void setImposto(double Imposto){
        this.imposto = Imposto;
    }
    
    public double getImposto(){
        return imposto;
    }
    
    public double calcularImposto(){
        return getSalarioBase() * (getImposto()/100);
    }
    
    public double calcularSalario(){
        return getSalarioBase() - calcularImposto();
    }
}
