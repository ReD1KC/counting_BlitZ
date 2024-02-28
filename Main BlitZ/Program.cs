using ConsoleTables;
using System;
using MainMethods;

Registration.Register(out var playerNames, out var blitz, out var field, out var targetSum);
Counting.Count(playerNames, blitz, field, targetSum);