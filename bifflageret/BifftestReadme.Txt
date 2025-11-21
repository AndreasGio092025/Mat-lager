
1*              Push_Enkel_Objekt 
 
 Begynner testen med og sjekke at jeg kan Pushe et enkelt objekt 
bruker da (Is.Empty) for å se om lagret da er tomt

2*              Tomt_Lager_invalidexception_

sjekker om programmet kjører invalidexception når lagret tomt

3*               Push_Flere_Elementer

tester at det kan pushes flere elementer/objekter i denne testen

4*              Pop_Returnere_siste_objekt_inn_fjerne_det

Tar et 2 element ("første") og ("siste") og viser at det ("siste") kommer ut og det ("første") blir fjernet
i testen

5*              Pop_Returnere_Sist_inn_først_ut

// Arrangerer fra biffLageret 
Tar inn di 2 biffene ("Biff1") og ("Biff2") 
altså 

//Act 
pusher: ("Biff1")
pusher : ("Biff2")

//Assert 
motsatt rekkefølge ut:
("Biff2")
(Biff1")
sjekker så at lagret er tomt(Lager.Isempty)

6*              Fungerer_med_Ulike_Typer

// arrangerer
jeg inn flere syntakser string,int og generisk

//Act 
legger til elementene lager1("123"), lager2("Ku"), lager3("new Biff")

//Assert 
Sjekker at elementene kommer ut samme rekkefølgen uanvhengig av typen:
lager 1
lager 2
lager 3
