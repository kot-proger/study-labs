domains 
s = string
i = integer

facts
animal(s, s, i)

predicates

nondeterm population(s, i, i)
nondeterm endangered(i)
nondeterm main_menu
nondeterm menu(s)

clauses

population(S, N, 0) :- animal(S, A, P), !, P2 = P + N, retract(animal(S, A, P)), assert(animal(S, A, P2)), save("Y:/уЄба/filp/lab4/db.txt"). 
population(S, N, 1) :- animal(S, A, P), !, P2 = P - N, retract(animal(S, A, P)), assert(animal(S, A, P2)), save("Y:/уЄба/filp/lab4/db.txt").
population(_, _, _) :- write("∆ивотное не найдено"), nl.
	
endangered(N) :- animal(S,A, P),	P <= N, write(S, " ( јреал: ",A,") - попул€ци€: ",P), nl, fail. 
endangered(_).

menu("1") :- write("===================="),nl,
	write("”величение попул€ции животных"),nl,
	write("∆ивотное: "), readln(S),
	write("–одилось: "), readint(N),
	population(S, N, 0), main_menu.
menu("2") :- write("===================="),nl,
	write("”меньшение попул€ции животных"),nl,
	write("∆ивотное: "), readln(S),
	write("”мерло: "), readint(N),
	population(S, N, 1), main_menu.
menu("3") :- write("===================="),nl,
	write("—писок вымирающих животных"),nl,
	write("”становите нижнюю попул€ции: "), readint(N),
	endangered(N), main_menu.
menu(_) :- main_menu.

main_menu :- nl,write("ƒействие:"),nl,
  	write("1 - ”величение попул€ции животных"),nl,
  	write("2 - ”меньшение попул€ции животных"),nl,
  	write("3 - —писок вымирающих животных"),nl,
  	readln(R), menu(R). 

goal
  consult("Y:/уЄба/filp/lab4/db.txt"),main_menu.
