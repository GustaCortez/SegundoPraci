/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.mavenproject7;

/**
 *
 * @author USUARIO
 */
public class Operaciones {
    
    private double valor, resultado;
    private int divisa, divisafinal;

    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public int getDivisa() {
        return divisa;
    }

    public void setDivisa(int divisa) {
        this.divisa = divisa;
    }

    public int getDivisafinal() {
        return divisafinal;
    }

    public void setDivisafinal(int divisafinal) {
        this.divisafinal = divisafinal;
    }

    public double getResultado() {
        return resultado;
    }

    public void setResultado(double resultado) {
        this.resultado = resultado;
    }

    //constructor
    public Operaciones() {
    }
    
   //Operaciones 
    public double convertir (){
        
     if(divisa == 0 && divisafinal == 1)
     {
     resultado = valor * 0.95;
     }   
     else if(divisa == 0 && divisafinal ==0)
     {
     resultado = valor;
     }
     else if(divisa == 0 && divisafinal ==2)
     {
     resultado = valor *7.67;
     }
     else if(divisa == 0 && divisafinal ==3)
     {
     resultado = valor *20.18;
     }
     else if(divisa == 1 && divisafinal ==0)
     {
     resultado = valor *1.05;
     }
     else if(divisa == 1 && divisafinal ==1)
     {
     resultado = valor;
     }
     else if(divisa == 1 && divisafinal ==2)
     {
     resultado = valor *8.08;
     }
     else if(divisa == 1 && divisafinal ==3)
     {
     resultado = valor *21.26;
     }
     
     else if(divisa == 2 && divisafinal ==0)
     {
     resultado = valor *0.13;
     }
     else if(divisa == 2 && divisafinal ==1)
     {
     resultado = valor *0.12;
     }
     else if(divisa == 2 && divisafinal ==2)
     {
     resultado = valor;
     }
     else if(divisa == 2 && divisafinal ==3)
     {
     resultado = valor *2.63;
     }
     else if(divisa == 3 && divisafinal ==0)
     {
     resultado = valor *0.050;
     }
      else if(divisa == 3 && divisafinal ==1)
     {
     resultado = valor *0.047;
     }
      else if(divisa == 3 && divisafinal ==2)
     {
     resultado = valor *0.38;
     }
     else if(divisa == 3 && divisafinal ==3)
     {
     resultado = valor;
     }
    return resultado;
    }
}
