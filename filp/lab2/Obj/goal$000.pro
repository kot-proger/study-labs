/*****************************************************************************

		Copyright (c) My Company

 Project:  LAB
 FileName: LAB.PRO
 Purpose: No description
 Written by: Visual Prolog
 Comments:
******************************************************************************/

include "lab.inc"

domains
	list = integer*

predicates

	p(list, list, list)
	member(integer, list)
	delete(integer, list, list)
	append(list, list, list)
clauses
	member(X, [X|_]) :-!.
	member(X, [_|T]) :- member(X, T).

	delete(_, [], []) :-!.
	delete(Y, [Y|T], T) :-!.
	delete(X, [Y|T], [Y|NT]) :- delete(X, T, NT).	
	
	append([], L, L).
	append([X|T], L, [X|R]) :- append(T, L, R).

	p(_, [], []) :-!.
	p(X, [Y|T], ZN) :- member(Y, X), delete(Y, X, R), p(R, [Y|T], Z), ZN=[Y|Z]. 
	p(X, [Y|T], Z) :- not(member(Y,X)), p(X, T, Z).
	
goal

	p([10,10,9,7,5,5,4], [5,7,10,9,4], Z).
	%member(5, [1,2,3,4,5]).
	%delete(3, [1,2,3,4,5,3,3], Z).
	%append([1,2,3], [3233], Z).