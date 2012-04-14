﻿// This file is a script that can be executed with the F# Interactive.  
// It can be used to explore and test the library project.
// By default script files are not be part of the project build.

// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#r "System.CoreEx.dll"
#r "System.Reactive.dll" 

#r "System.Data.Entity.dll"
#r "FSharp.Data.TypeProviders.dll"

#load "..\CommandSide\Events.fs"
#load "..\CommandSide\Domain.fs"
#load "..\CommandSide\EventStorage.fs"
//#load "..\CommandSide\EventStorageRx.fs"
#load "..\CommandSide\Commands.fs"
#load "..\CommandSide\CommandHandler.fs"

open Events
open System
open CommandHandler
open Commands

#load "ReadModel.fs"

open ReadModel

let listView = new InventoryListView()
let detailsView = new InvenotryItemDetailView()

let itemId1 = Guid.NewGuid()
CreateInventoryItem(itemId1, "MyItem") |> CommandHandler