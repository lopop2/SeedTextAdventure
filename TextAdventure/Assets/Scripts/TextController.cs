using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {Earth, Earth_1, Earth_2, Intro, ship, ship_1, ship_2, Epic, Epic201367065b, Epic201367065c, Epic201367065d, Epic201367065d_1, TauCeteE, TauCeteE_1, Mars, Mars_1, Kepler,  
		Kepler_1,  Kepler22b, Kepler62e, Kepler62f, Kepler186f, Kepler296e, Kepler296f, Kepler438b, Kepler440b, Kepler442b, Kepler452b, Kepler452b_1, Gliese, Gliese_1, Gliese163c, 
		Gliese581d, Gliese581g, Gliese581g_1, clone, explore, denied, allowed, laser, terraform, terraform_1, eliminate, android, terminator, explore_1, radiation, Alien} 
	
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.Intro;
		
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.Intro) {state_Intro();}
		else if (myState == States.Earth) {state_Earth();}
		else if (myState == States.Earth_1) {state_Earth_1();}
		else if (myState == States.Earth_2) {state_Earth_2();}
		else if (myState == States.ship) {state_ship();}
		else if (myState == States.ship_1) {state_ship_1();}
		else if (myState == States.ship_2) {state_ship_2();}
		else if (myState == States.Kepler) {state_Kepler();}
		else if (myState == States.Kepler_1) {state_Kepler_1();}
		else if (myState == States.Kepler22b) {state_Kepler22b();}
		else if (myState == States.Kepler62e) {state_Kepler62e();}
		else if (myState == States.Kepler62f) {state_Kepler62f();}
		else if (myState == States.Kepler186f) {state_Kepler186f();}
		else if (myState == States.Kepler296e) {state_Kepler296e();}
		else if (myState == States.Kepler296f) {state_Kepler296f();}
		else if (myState == States.Kepler438b) {state_Kepler438b();}
		else if (myState == States.Kepler440b) {state_Kepler440b();}
		else if (myState == States.Kepler442b) {state_Kepler442b();}
		else if (myState == States.Kepler452b) {state_Kepler452b();}
		else if (myState == States.Kepler452b_1) {state_Kepler452b_1();}
		else if (myState == States.Gliese) {state_Gliese();}
		else if (myState == States.Gliese_1) {state_Gliese_1();}
		else if (myState == States.Gliese163c) {state_Gliese163c();}
		else if (myState == States.Gliese581d) {state_Gliese581d();}
		else if (myState == States.Gliese581g) {state_Gliese581g();}
		else if (myState == States.Gliese581g_1) {state_Gliese581g_1();}
		else if (myState == States.Epic) {state_Epic();}
		else if (myState == States.Epic201367065b) {state_Epic201367065b();}
		else if (myState == States.Epic201367065c) {state_Epic201367065c();}
		else if (myState == States.Epic201367065d) {state_Epic201367065d();}
		else if (myState == States.Epic201367065d_1) {state_Epic201367065d_1();}
		else if (myState == States.denied) {state_denied();}
		else if (myState == States.allowed) {state_allowed();}
		else if (myState == States.laser) {state_laser();}
		else if (myState == States.TauCeteE) {state_TauCeteE();}
		else if (myState == States.TauCeteE_1) {state_TauCeteE_1();}
		else if (myState == States.terraform) {state_terraform();}
		else if (myState == States.terraform_1) {state_terraform_1();}
		else if (myState == States.Mars) {state_Mars();}
		else if (myState == States.Mars_1) {state_Mars_1();}
		else if (myState == States.clone) {state_clone();}
		else if (myState == States.explore) {state_explore();}
		else if (myState == States.terminator) {state_terminator();}
		else if (myState == States.eliminate) {state_eliminate();}
		else if (myState == States.android) {state_android();}  
		else if (myState == States.explore_1) {state_explore_1();}
		else if (myState == States.Alien) {state_Alien();}	
		else if (myState == States.radiation) {state_radiation();}
		
	}				
	void state_Intro() {
		text.text = "It is the year 2017... \n " +
			"Press space key " ;
		if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.Earth;	
		}
	}		
	void state_Earth() {
		text.text = "The human race is no more, with the exception " + 					
			"of a few scientists.\n " +
				"You have been provided with sufficiently " +
				"diverse specimens of DNA, and all of the " +
				"data needed, to find a suitable planet " +
				"and clone the beginning of the new human " +
				"race to populate it.\n " +
				"Press S to board escape ship or T to go into " +
				"terminator mode on the remaining humans and " + 
				"repopulate the world with androids. " ;
		
		if (Input.GetKeyDown(KeyCode.S)) {					
			myState = States.ship;
			
		}						
		else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.terminator;													
		}
	}
	
	void state_ship() {
		text.text = "For which planet do you wish to set course? \n\n " +
			"Press G for Gliese planets, " +
				"press K for Kepler planets, E for Epic, T for " +
				"Tau Cete e, or M for Mars. " ;
		if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.Kepler;
		}
		else if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.Gliese;
		}
		else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.Epic201367065d;
		}
		else if (Input.GetKeyDown(KeyCode.T)) { 
			myState = States.TauCeteE;
		}
		else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.Mars;
		} 
	}
	void state_terminator() {
		text.text = "Eliminate the remaining pathetic humans? \n\n " +
			"Press V to eliminate humans, " +
				"press W to construct android facility" ;
		if (Input.GetKeyDown(KeyCode.V)) {
			myState = States.eliminate;
		}
		else if (Input.GetKeyDown(KeyCode.W)) {
			myState = States.android;
		}
	}
	void state_eliminate() {
		text.text = "You may begin hunting the humans. " ;
	}	
	void state_android() {
		text.text = "You have begun constructing an android race, with which to repopulate Earth. " ;
	}		 
	void state_ship_1() {
		text.text = "For which planet do you wish to set course? \n\n " +
			"Press G for Gliese planets, " +
				"press K for Kepler planets, E for Epic, T for " +
				"Tau Cete e, or M for Mars. " ;
		if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.Kepler_1;
		}
		else if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.Gliese_1;
		}
		else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.Epic201367065d;
		}
		else if (Input.GetKeyDown(KeyCode.T)) { 
			myState = States.TauCeteE_1;
		}
		else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.Mars_1;
		}
	}	 
	void state_ship_2() {
		text.text = "For which planet do you wish to set course? \n\n " +
			"Press G for Gliese planets, " +
				"press K for Kepler planets, E for Epic, T for " +
				"Tau Cete e, or M for Mars. " ;
		if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.Kepler_1;
		}
		else if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.Gliese_1;
		}
		else if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.Epic201367065d_1;
		}
		else if (Input.GetKeyDown(KeyCode.T)) { 
			myState = States.TauCeteE_1;
		}
		else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.Mars_1;
		} 
	}
	void state_Kepler() {
		text.text = "For which Kepler planet do you wish to set course? \n\n " +
			"Press A for 22b, B for 62e, C for 62f, D for 186f, " +
				"F for 296e, G for 296f, H for 438b, I for 440b, J for 442b, or P for 452b. " ;
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.Kepler22b;
		}			  					
		else if (Input.GetKeyDown (KeyCode.B)) {		
			myState = States.Kepler62e;
		}			
		else if (Input.GetKeyDown (KeyCode.C)) {		
			myState = States.Kepler62f;
		}			
		else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.Kepler186f;
		}			
		else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.Kepler296e;
		}			
		else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.Kepler296f;
		}	
		else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.Kepler438b;
		}			
		else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.Kepler440b;
		}			
		else if (Input.GetKeyDown (KeyCode.J)) {
			myState = States.Kepler442b;
		}			
		else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.Kepler452b;		
		}
	}	
	void state_Kepler_1() {
		text.text = "For which Kepler planet do you wish to set course? \n " +
			"Press A for 22b, B for 62e, C for 62f, D for 186f, " +
				"F for 296e, G for 296f, H for 438b, I for 440b, J for 442b, or P for 452b. " ;
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.Kepler22b;
		}			  					
		else if (Input.GetKeyDown (KeyCode.B)) {		
			myState = States.Kepler62e;
		}			
		else if (Input.GetKeyDown (KeyCode.C)) {		
			myState = States.Kepler62f;
		}			
		else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.Kepler186f;
		}			
		else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.Kepler296e;
		}			
		else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.Kepler296f;
		}	
		else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.Kepler438b;
		}			
		else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.Kepler440b;
		}			
		else if (Input.GetKeyDown (KeyCode.J)) {
			myState = States.Kepler442b;
		}			
		else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.Kepler452b_1;			
		}	
	}	void state_Kepler22b() {
		text.text = "You have arrived on Kepler 22b. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
		
	}	void state_Kepler62e() {
		text.text = "You have arrived on Kepler 62e. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler62f() {
		text.text = "You have arrived on Kepler 62f. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler186f() {
		text.text = "You have arrived on Kepler 186f. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler296e() {
		text.text = "You have arrived on Kepler 296e. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler296f() {
		text.text = "You have arrived on Kepler 296f. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler438b() {
		text.text = "You have arrived on Kepler 438b. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.radiation;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler440b() {
		text.text = "You have arrived on Kepler 440b. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Kepler442b() {
		text.text = "You have arrived on Kepler 442b. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}
	void state_Kepler452b() {
		text.text = "The surface gravity on Kepler 452 b is twice that of Earth, and the atmosphere is significantly denser. \n\n " +
			"Press S to return to ship, or U to terraform planet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.terraform;
		}
	}
	void state_Kepler452b_1() {
		text.text = "The surface gravity on Kepler 452 b is twice that of Earth, and the atmosphere is significantly denser. \n\n " +
			"Press S to return to ship, or U to terraform planet." ;
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.terraform_1;
		}
	}	
	
	void state_Gliese() {
		text.text = "For which Gliese planet do you wish to set course? \n\n " +
			"Press X for 163c, Y for 581d, or Z for 581g. "; 
		if (Input.GetKeyDown (KeyCode.X)) {
			myState = States.Gliese163c;
		}			  					
		else if (Input.GetKeyDown (KeyCode.Y)) {		
			myState = States.Gliese581d;
		}			
		else if (Input.GetKeyDown (KeyCode.Z)) {		
			myState = States.Gliese581g;
		}
	}			
	void state_Gliese_1() {
		text.text = "For which Gliese planet do you wish to set course? \n\n " +
			"Press X for 163c, Y for 581d, or Z for 581g. "; 
		if (Input.GetKeyDown (KeyCode.X)) {
			myState = States.Gliese163c;
		}			  					
		else if (Input.GetKeyDown (KeyCode.Y)) {		
			myState = States.Gliese581d;
		}			
		else if (Input.GetKeyDown (KeyCode.Z)) {		
			myState = States.Gliese581g_1;
		}		
	}	void state_Gliese163c() {
		text.text = "You have arrived on Gliese 163c. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}	void state_Gliese581d() {
		text.text = "You have arrived on Gliese 581d. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}		
	void state_Gliese581g() {
		text.text = "You have arrived on Gliese 581g. " +
			"The average temperature on this planet ranges from -24 to -10 Fahrenheit. \n\n " +
				"Press S to return to ship, or U to terraform planet. ";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		
		else if (Input.GetKeyDown (KeyCode.U)) { 
			myState = States.terraform;
		}
	}			
	void state_Gliese581g_1() {
		text.text = "You have arrived on Gliese 581g. " +
			"The average temperature on this planet ranges from -24 to -10 Fahrenheit. \n\n " +
				"Press S to return to ship, or U to terraform planet. ";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		
		else if (Input.GetKeyDown (KeyCode.U)) { 
			myState = States.terraform_1;
		}
	}	void state_Epic() {
		text.text = "For which Epic planet do you wish to set course? \n\n " +
			"Press B, C, or D. "; 
		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.Epic201367065b;
		}			  					
		else if (Input.GetKeyDown (KeyCode.C)) {		
			myState = States.Epic201367065c;
		}			
		else if (Input.GetKeyDown (KeyCode.D)) {		
			myState = States.Epic201367065d;
		}
		
	}		
	void state_Epic201367065b() {
		text.text = "You have arrived on Epic 201367065b. " +
			"Unsuitable for construction of cloning facility, as entire planet is enveloped in water. \n\n " +
				"Press S to return to ship, or U to terraform planet. ";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}    
		else if (Input.GetKeyDown (KeyCode.U)) { 
		}          myState = States.terraform;
	}
	
	void state_Epic201367065c() {
		text.text = "You have arrived on Epic 201367065c. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}							
	void state_Epic201367065d() {
		text.text = "As you near the planet, an unidentified earth ship approaches, and the Captain requests to board your craft. \n\n " +
			"Press M to deny boarding request, N to allow boarding, or O to cut unidentified ship in half with the laser " +
				"installed on your craft. " ;
		if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.denied;
		}
		else if (Input.GetKeyDown (KeyCode.N)) {
			myState = States.allowed;
		}
		else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.laser;	
		}
	}		
	void state_Epic201367065d_1() {
		text.text = "You have arrived on Epic201367065d. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore_1;
		}
	}	
	void state_explore_1() {
		text.text = "You discover the wreck of the hostile ship, and note that it is powered by a warp drive engine.  Upon entering the ship, " +   
			"you find correspondence indicating that this unknown, evidently extraterrestrial group has killed the scientists on Earth, " +
				"and stolen the technology to install AI into a human body.  Press E Key to acquire warp drive technology and return to Earth. " ;
		if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.Earth_2;
		}					
	}
	void state_Earth_2() {
		text.text = "You return to the bunker in which you were activated, and find the scientists/engineers all dead.  One of their hands clutches a " +
			"slip of paper, on which are written the home planet coordinates of the alien murderers.  It is located in a distant solar system, " +
				"but the warp drive technology will shorten the time drastically, making the voyage feasible.  Press the A key to construct a warp " +
				"drive engine for your craft, and set out for the alien home world. " ; 
		if (Input.GetKeyDown (KeyCode.A)) {
			myState = States.Alien;
		}					
	}
	void state_Alien() {
		text.text = "You have tracked down and eliminated the aliens responsible for the murder of the scientists.  You have also recovered the " +
			"technology to install artificial intelligence into a human body.  Do you wish to clone a body for yourself? " ;
	}	
	void state_denied() {
		text.text = "The unknown ship fires a grappling hook on a cable, which attaches to your craft.  \n\n " +
			"Press O key to cut unidentified ship in half with the laser installed on your craft. " ;
		
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.laser;
		}
		
	}
	void state_allowed() {
		text.text = "Hostiles have boarded your ship.  Press V key to activate ship's self destruct and launch escape pod. " ; 
		
		if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.Earth_1;
		}
	}		
	void state_Earth_1() {
		text.text = "You have made it back to Earth, but the cloning technology was lost with your ship. " ;
	} 	
	void state_laser() {
		text.text = "Unidentified ship destroyed. \n\n " +
			"Press S key. " ;
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship_2;
		}
	}
	void state_radiation() {
		text.text = "Kepler 438b not habitable due to the large amount of radiation it receives. \n\n " +
			"Press S key. " ;
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}								
		
	}		void state_TauCeteE() {
		text.text = "En route, you discover an abandoned alien ship containing terraforming technology and equipment. \n\n " +
			"Press L to continue to Tau Cete with the alien technology, " +
				"or S to bring it to another planet. " ;
		if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.TauCeteE_1;
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship_1;
		}	
	}	void state_TauCeteE_1() {
		text.text = "You have arrived on Tau Cete. " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. " ;
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.explore;
		}
	}		
	
	void state_Mars() {
		text.text = "You have arrived on Mars. " +
			"Due to the lack of a magnetosphere, and the resulting thin atmosphere, " +
				"cosmic radiation may cause damage to DNA.  Additionally, temperatures are similar to those of Antarctica. \n\n " +
				"Press S to return to ship, or U to terraform planet. ";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		
		else if (Input.GetKeyDown (KeyCode.U)) { 
			myState = States.terraform;
		}
	}	void state_Mars_1() {
		text.text = "You have arrived on Mars. " +
			"Due to the lack of a magnetosphere, and the resulting thin atmosphere, " +
				"cosmic radiation may cause damage to DNA.  Additionally, temperatures are similar to those of Antarctica. \n\n " +
				"Press S to return to ship, or U to terraform planet. ";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		
		else if (Input.GetKeyDown (KeyCode.U)) { 
			myState = States.terraform_1;
		}
		
		
	}	void state_terraform() {
		text.text = "You do not yet have terraforming capability. \n\n " +
			"Press S to board the ship and set course for a different planet, " +
				"or E to return to Earth. ";
		
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;
		}
		else if (Input.GetKeyDown (KeyCode.E)) { 
			myState = States.Earth;
		}
	}	void state_terraform_1() {
		text.text = "You have terraformed the planet for human habitation. \n\n " +
			"Press Q to construct cloning facility, " +
				"or R to explore planet. ";
		
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.R)) { 
			myState = States.explore;
		}	
		
	}	void state_clone() {
		text.text = "You have begun cloning the new human race. ";
		
	}	void state_explore() {
		text.text = "Nothing detrimental to the cloning process found. " +
			"You may begin cloning the new human race. " +
				"Press Q to construct cloning facility, or S to return to ship ";
		if (Input.GetKeyDown (KeyCode.Q)) {
			myState = States.clone;
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.ship;  
		}
	}
}