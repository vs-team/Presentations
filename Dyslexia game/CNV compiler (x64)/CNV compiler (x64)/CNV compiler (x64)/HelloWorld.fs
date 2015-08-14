module Pippo
let a = [1..10]
let query1 = query { for customer1 in a do
                     select customer1 }