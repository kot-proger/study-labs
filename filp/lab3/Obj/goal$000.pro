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
llist = list*


predicates

edge(integer,integer).
member(integer, list).
reverse(list, list).
reverse1(list, list, list).
pathall(integer,  llist).
pathall1(llist, llist, llist).
path(integer, integer, list, list).
next(integer, integer).
getlen(list, integer).
getlen(llist, integer).
ident(llist, list).
ident1(list, list).
cycles(list, llist, integer).
cycles1(llist, llist, llist).
append(llist, llist, llist).

clauses

edge(1, 2).
edge(4, 6).
edge(2, 3).
edge(2, 6).
edge(3, 4).
edge(3, 5).
edge(4, 5).

member(El, [El|_]).
member(El, [_|Tail]):- member(El, Tail).

reverse(X, Y):- reverse1(X, [], Y).
reverse1([], R, R).
reverse1([X|T], S, R):- reverse1(T, [X|S], R).
	
next(X, Y):- edge(X, Y).
next(X, Y):- edge(Y, X).

path(X, Y, L, P):- next(X, Y), reverse([Y|L], P).
path(X, Y, L, P):- next(X, S), S<>Y, not(member(S, L)), path(S, Y, [S|L], P).

getlen([],0).
getlen([_|L], N):- getlen(L, N1), N = N1+1.

ident([], _):- fail.
ident([F|T], Y):- getlen(F, L), getlen(Y, L1), L<>L1, !, ident(T, Y).
ident([F|_], Y):- ident1(F, Y), !.
ident([_|T], Y):- ident(T, Y).
ident1([], _).
ident1([F|T], Y):- member(F, Y), ident1(T, Y).

pathall(X, PL):- findall(P, path(X, X, [], P), PF), pathall1(PF, PL, []).
pathall1([], PA, PA).
pathall1([P|T], PA, PB):- getlen(P, Len), Len<3, pathall1(T, PA, PB).
pathall1([P|T], PA, PB):- getlen(P, Len), Len>2, not(ident(PB, P)), !, pathall1(T, PA, [P|PB]).
pathall1([P|T], PA, PB):- getlen(P, Len), Len>2, pathall1(T, PA, PB).
  
append([], L, L).
append([_|T], L, [_|R]):- append(T, L, R).  
  
cycles([], Cyc, N):- getlen(Cyc, N).
cycles([F|T], Cyc, N):- pathall(F, PA), cycles1(Cyc, PA, C1), cycles(T, C1, N).
cycles1(X, [], X).
cycles1(X, [F|T], Y):- not(ident(X, F)), !, cycles1([F|X], T, Y).
cycles1(X, [_|T], Y):- cycles1(X, T, Y).

goal

%pathall1([[3,5,4], [2,3,4], [7,5], [4,5,3]], PL, []).

%pathall(3, P).

%ident([[3,5,4], [2,3,4], [7,5]], [4,5,3]).

cycles([1, 2, 3, 4, 5, 6], [], N).




