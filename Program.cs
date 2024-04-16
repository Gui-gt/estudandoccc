using System;// Importando biblioteca para ter configurações padrões de código.

public class enemyAI//Criando a classe enimigos AI                                              /CLASSE
{
    int speed;//valor inteiro chamado speed
    float health;//Valor booleano
    string enemyName;//string                                                                   //VARIAVEIS

    WeaponArmy weapon;//classe referenciada e atribuida como weapon

    int[] intarray = new int [] {1,2,3,4,5};//criando e colocando valores em um Array

    List<int> intList = new List<int>() {1,2,3,4,5};//criando e colocando valores em uma Lista


    void atack()//criando método
    {
        if(speed >= 0)
        {
            weapon.Shoot();//referenciada e usando o metodo shoot
        }
    }
    void Movement () {//criando um método                                                        //METODOS

            foreach (int intNumbers in intarray)//usando pesquisa foreach usando Array
            {
                
            }
    for (int i = 0; i < intarray.Length; i++)
    {
        int currentNumber = intarray[1];
    }
    for (int i = 0; i < intList.Count; i++)
    {
        int currentNumber = intList[1];
    }

        intList.Remove(1)//remove um valor da lista
        if(speed <= 0 && health > 10)//condicional if
        {

        }
        else{

        }
    }
    void Dead ()//método tbm
    {
        if(health <= 0){

        }
        else
        {

        }
    }
}

public class WeaponArmy //outra classe e diferente da primeira
{
    float damage;                                                                               //VARIAVEIS
    float fireRate;

    public void Shoot ()//PUBLIC pode ser usado para referenciar o metodo dentro de outra classe   //METODOS
    {

    }

}