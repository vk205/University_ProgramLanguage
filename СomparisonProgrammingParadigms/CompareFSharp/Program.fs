open System 

// Наборы тестов
let test1 = [(0, 1); (1,2); (2,3); (2,0)] // содержит цикл
let test2 = [(0, 1); (1,2); (1,6); (2,3); (3, 6); (4, 5)] // граф не связный
let test3 = [(1,0)] // одно ребро
let test4 = [(3, 1); (3, 6); (1,6); (1,4); (1,0); (6,4); (6,8); (8,7); (4,2); (0,2); (2,5); (7,5); (2,7) ] // случайный сценарий
let test5 = [(7,2); (2,5); (3,0);  (0,9); (9,7); (7,6);  (6,5); (7,8);(3,4);(4,9); (8,5); (5,1)] 
let test6 = [(4,1); (4,3); (1,5); (3,2); (5,2); (2,0)] // лучший сценарий (вершины отсортированы в прямом порядке)
let test7 = [(2,0); (5,2); (3,2); (1,5); (4,3); (4,1)] // худший сценарий (вершины отсортированы в обратном порядке)
let test8 = [(0, 1); (0, 2); (0, 7); (1, 2); (3, 1); (3, 4); 
(3, 5); (4, 20); (5, 4); (5, 6); (5, 11); (6, 2); (6, 10); (7, 8); 
(7, 9); (9, 8); (9, 10); (10, 11); (11, 14); (12, 8); (12, 10); 
(12, 13); (13, 11); (13, 15); (15, 16); (15, 17); (16, 14); (16, 18);
(16, 19); (17, 16); (17, 18); (19, 18); (20, 10); (20, 14); (20, 19)]

// номер вершины с максимальным номером
let n1 = 3
let n2 = 6
let n3 = 1
let n4 = 8
let n5 = 9
let n6 = 5
let n7 = 5
let n8 = 20


// Вычисление полустепени вершины
let indegreeNode edges node = 
    let rec iN list acc= 
        match list with
        | [] -> acc
        | (a,b)::t -> if b=node then (iN t acc+1) else (iN t acc)
    iN edges 0

 // Получение списка полустепеней вершин
let indegreeList n edges = 
    let rec iL k acc =
        match k with
        | -1->acc
        | _ -> iL (k-1) ([indegreeNode edges k]@acc)
    iL n []

// Получение нулевых полустепеней (начальная инциализация)
let getZero ind = 
    let rec gZ list acc n= 
        match list with
        | [] -> acc
        | h::t -> if h=0 then gZ t (n::acc) (n+1) else gZ t acc (n+1)
    gZ ind [] 0

// Проверить необходимость добавления вершины node в очередь
let addGq node ind = 
    let rec aG n ind_ = 
        match ind_ with 
        | []->false
        | h::t -> if n=node then (if h = 0 then true else false) else aG (n+1) t
    aG 0 ind

// Обновить очередь
let updateGq gq ind adj= 
    let rec uG adj_ acc =
        match adj_ with
        | [] -> acc
        | h::t-> if ((addGq h ind)=true)  then uG t (h::acc) else uG t acc
    
    (uG adj []) @ gq

// Уменьшить полустепень вершины
let decInd node ind = 
    let rec dI n ind_ acc = 
        match ind_ with
        | [] -> acc
        | h::t -> if n=node then dI (n+1) t (acc @ [h-1]) else dI (n+1) t (acc @ [h])
    dI 0 ind []

// Обновить список полустепеней вершин
let updateInd ind adj=
    let rec uI adj_ ind_ =
        match adj_ with
        | [] -> ind_
        | h::t-> uI t (decInd h ind_)   
    uI adj ind

// Поиск прямых потомков вершины node    
let adjNode node edges = 
    let rec aN l acc = 
        match l with
        | []-> acc
        | (a,b)::t -> if a=node then aN t (acc@[b]) else aN t acc
    aN edges []

// Вычисление длины массива
let len list = 
    let rec l list_ acc = 
        match list_ with 
        | [] -> acc
        | h::t -> l t acc+1
    l list 0

let topSort edges n = 
    // создаем список полустепеней
    let indegree = indegreeList n edges
    // создаем очередь и заполняем текущими 0
    let q = getZero indegree 

    let rec tS gq ind acc =
        match gq with
        // если конец очереди, то получили результирующий список
        | []->acc
        // иначе извлекаем голову, обновляем значения полустепеней, заносим новые вершины с 0 полустепенями
        | h::t -> 
         let adj = adjNode h edges // потомки
         let new_ind = updateInd ind adj // новый список полустепеней
         let new_gq = updateGq t new_ind adj // обновленная очередь
         tS new_gq new_ind (acc@[h])
    
    let res =  tS q indegree []  
    if len res=n+1 then res else []

let main = 
    let timer = System.Diagnostics.Stopwatch.StartNew()
    let res_ = topSort test8 n8
    timer.Stop()
    printfn "runtime = %O ms" timer.ElapsedMilliseconds
    if res_ = [] then printfn "Topological sorting imbosible."
    else printfn "RESULT %A" res_
