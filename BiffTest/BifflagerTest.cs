using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using Mat_generic;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Mat_generic
{
 public class BiffLagerTests
 {
   [Fact]  
   public void Push_Enkel_Objekt()
    {       //Arrange
            var lager = new BiffLager<Biff>();
            var biff = new Biff
       
       
        {   //Act
            Type = BiffType.Entrecote,
            VektKg = 1.1,
            SlakteDato = DateTime.Today,

        };
      
        
        //Assert
        lager.push(biff);
        Assert.Equal(1, lager.Count);
        Assert.False(lager.IsEmpty);

    
        }

        [Fact]
        public void Tomt_Lager_invalidexception_()
        {
        
        var lager = new BiffLager<Biff>();
        Assert.Throws<InvalidOperationException>(() => lager.pop());
        
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(10)]
        public void Push_Flere_Elementer(int antall)
    {
        //Arrange
        var lager = new BiffLager<int>();
       
       //Act
       for (int i = 0; i < antall; i++) 
       lager.push(i);
       
        //Assert
        Assert.Equal(antall, lager.Count);
    
    }

        [Fact]
        public void Pop_Returnere_siste_objekt_inn_fjerne_det()
        {
            //Arrange
        var lager = new BiffLager<string>();
        lager.push("først");
        lager.push("sist");

        //Akt
        var resultat = lager.pop();

        // Assert
        Assert.Equal("sist",resultat);
        Assert.Equal(1,lager.Count);
     }
        [Fact]
        public void Pop_Returnere_Sist_inn_først_ut()
        { 
            //Arrange
        var lager = new BiffLager<Biff>();
        var Biff1 = new Biff {Type = BiffType.Entrecote, VektKg = 1.2 };
        var Biff2 = new Biff {Type = BiffType.Tbone, VektKg = 0.9};

            //Act
            lager.push(Biff1);
            lager.push(Biff2);

            //Assert
            Assert.Same(Biff2, lager.pop());
            Assert.Same(Biff1, lager.pop());
            Assert.True(lager.IsEmpty);
    }    
    [Fact]
    public void Fungerer_med_Ulike_Typer()
       {
        //Arrangement
       var lager1 = new BiffLager<int>();
       var lager2 = new BiffLager<string>();
       var lager3 = new BiffLager<Biff>();

        //Act
        lager1.push(123);
        lager2.push("Ku");
        lager3.push(new Biff());

        //Assert
       Assert.Equal(1,lager1.Count);
       Assert.Equal(1,lager2.Count);
       Assert.Equal(1,lager3.Count);
   
   }
}

}