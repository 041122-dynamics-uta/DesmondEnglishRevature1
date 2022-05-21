        /* Salina helped clarify a lot and helped with coding */
        
        
        //Display welcome text and game explanation
        const greeting = document.createElement('h1');
        document.body.append(greeting);
        greeting.innerText = "Welcome to the Trail Mix Hunger Games 2022!!!"
        
        const rule = document.createElement('h2');
        document.body.append(rule);
        rule.innerText = "Here are the Rules:"
        
        const rules = document.createElement('h3');
        document.body.append(rules);
        rules.innerText = "First, I will ask for a number starting a range?\nNext, I will ask for a second number to exit the range?\n\n After the calculations are done numbers will print accordingly:\n\n If the number is a multiple of three, 'Sweet' will print.\n If the number is a multiple of five, 'Salty' will print.\n Lastly if the numbers which are multiples of three and five, Sweet'nSalty will print instead of the number.\n\n To Survive Click START!"
        
        // Button Creation 
        // click start to start button, first enter number button
        // second enter button, calculate button
        let startB = document.createElement('button');
        document.body.append(startB);
        startB.innerText = "START!";
        
        let firstnum = document.createElement("h4")
        let inputsnum = document.createElement("input")
        let submitsnum = document.createElement("button")
        submitsnum.innerText = "ENTER"
        let startnum = 0
        
        let secondnum = document.createElement('h4');
        let inputenum = document.createElement('input');
        let submitenum = document.createElement('button');
        submitenum.innerText = "ENTER";
        let endnum = 0
        
        
        let error = document.createElement('h5');
        let output = document.createElement('p');
        
        // p elements
        let sweetFinalCount = document.createElement('p');
        let saltyFinalCount = document.createElement('p');
        let sweetNSaltyFinalCount = document.createElement('p');
        
        // restart button
        let submitR = document.createElement('button');
        submitR.innerText = "RESTART";
        
        
        
        // click event listener to start button
        startB.addEventListener('click', () => {
            document.body.innerHTML = "";
            document.body.appendChild(firstnum);
            firstnum.innerText = "Enter your first number";
            document.body.appendChild(inputsnum);
            document.body.appendChild(submitsnum);          
        });
        
        //  enter button click event do the following:
        submitsnum.addEventListener('click', () => {
            startnum = inputsnum.value;
            document.body.innerHTML = "";
            document.body.appendChild(secondnum);
            secondnum.innerText = "Enter your second number";
            document.body.appendChild(inputenum);
            document.body.appendChild(submitenum);
        });
        
        
        // enter button click event do the following:
        submitenum.addEventListener('click', () => {
            endnum = inputenum.value;
            document.body.innerHTML = "";
            if (validate(startnum, endnum)) {
                sweetAndSalty(startnum, endnum);
            }
            document.body.appendChild(submitR);
        })
        
        // restart button click:
        submitR.addEventListener('click', () => {
            location.reload();
        })
        
        //input validation
        function validate(startnum, endnum) {
            // postive numbers only
            // at least 200 numbers apart
            // no more than 10,000 numbers apart

            if (startnum < 0 || endnum < 0) {
                document.body.appendChild(error);
                error.className = 'errors';
                error.innerText = "Enter a number greater than 0";
                return false;
            } else if ((endnum - startnum) < 200) {
                document.body.appendChild(error);
                error.className = 'errors';
                error.innerText = "Start and final numbers must be more than 200 numbers apart.";
                return false;
            } else if ((endnum - startnum) > 10000) {
                document.body.appendChild(error);
                error.className = 'errors';
                error.innerText = "Start and final numbers must be less than 10000 numbers apart.";
                return false;
            } else if (endnum <= startnum) {
                document.body.appendChild(error);
                error.className = 'errors';
                error.innerText = "Starting number must be less than final number.";
                return false;
            } else {
                
                return true;
            }
        } 
        
        // calculations
        function sweetAndSalty(startnum, endnum) {
            let sweetCount = 0;
            let saltyCount = 0;
            let sweetNSaltyCount = 0;
            let str = "";
            
            // 40 numbers per line
            while (startnum <= endnum) {
                for (let i = 0; i < 40; i++) {
                    if (startnum % 5 === 0 && startnum % 3 === 0) {
                        str += "<span>SweetnSalty </span>";
                        sweetNSaltyCount++;
                    } else if (startnum % 3 === 0) {
                        str += "<span>Sweet </span>";
                        sweetCount++;
                    } else if (startnum % 5 === 0) {
                        str += "<span>Salty </span>";
                        saltyCount++;
                    } else {
                        str += `${startnum.toLocaleString()} `;
                    }
                    if (startnum === endnum) {
                        break;
                    }
                    startnum++;
                }
            }
            //TEXT Output
            output.innerHTML = `${str}`;
            document.body.appendChild(output);
            document.body.appendChild(sweetFinalCount);
            sweetFinalCount.innerText = `Total Sweet ~ ${sweetCount}`;
            document.body.appendChild(saltyFinalCount);
            saltyFinalCount.innerText = `Total Salty ~ ${saltyCount}`;
            document.body.appendChild(sweetNSaltyFinalCount);
            sweetNSaltyFinalCount.innerText = `Total SweetNSalty ~ ${sweetNSaltyCount}`;
        } 
        
        
        // let welcome = document.body
        // let firstdiv = document.createElement("div")
        // firstdiv.innerText = "Welcome to the Trail Mix Hunger Games 2022!!!"
        // welcome.append(firstdiv)
        // let rules = document.body
        // let seconddiv = document.createElement("div")
        // seconddiv.innerText = "Here are the Rules:"
        // rules.append(seconddiv)
        // document.write("<br>");
        // document.write("Welcome to the Trail Mix Hunger Games 2022!!!<br>");
        // document.write("<br>Here are the Rules:");
        // document.write("Want to play click the button!");
        // document.write("<br>");

        // function first() {
        //     document.getElementById("firsts").innerHTML = "Start Here";
        //   }
        
        //   function getData1(){
        //     // var data = [];
        //     // data[0] = document.getElementByName('firstnum')[0].value;
        //     // console.log(data); // Check the console for the values for every click.
        //     // return data;   
        //     document.getElementByID("myForm1").style.display = 'block';
        // }
        //  //var x = getData1();
        
        // function getData2(){
        //     // var data = [];
        //     // data[0] = document.getElementByName('secondnum')[0].value;
        //     // console.log(data); // Check the console for the values for every click.
        //     // return data;   
        //     document.getElementByID("myForm2").style.display = 'block';
        // }
        // //var y = getData2();

        // function getCalculation(){
        //     // var data = [];
        //     // data[0] = document.getElementByName('secondnum')[0].value;
        //     // console.log(data); // Check the console for the values for every click.
        //     // return data;   
        //     document.getElementByID("calculations").style.display = 'block';
        // }

        // document.write("<br>");
        // document.write("<br>Enter a second number to exit the range?");
        // document.write("<br>");
        // Delete button - restart(play again)
        // document.write("<br>Can you survive the Trail Mix Hunger Games again?");
        // document.write("<br>");

//#region 
// Instructions
// As always: 
// When the number is a multiple of three, print “Sweet” instead of the number 
// If the number is a multiple of five, print “salty” instead of the number.  
// For numbers which are multiples of three and five, print “Sweet’nSalty” instead of the number. 
// The difference in this project is that you will use JS to manipulate the DOM and print the numbers and words to the web page (NOT the console). 
// This will be a single page application that takes the user through the following steps by displaying and not displaying text and instructions.  
// Each line will be displayed one at a time.  
// “Please enter a starting number” 
// “Please enter a final number” 
// “Please press enter to display your results.” 
// You will start with only the template html (an empty <body>) 
// You will add, delete, and alter elements exclusively using JavaScript DOM manipulation as the user moves through the steps.  
// You must display each step separately one at a time, while not displaying the other steps.  
// You must have styling using internal (not inline) styling. 
// This means you will have to plan ahead for class/id names to pair with pre-created (by you) CSS rulesets.
// startid, stopnumbersid, 
// Then, you will apply those class/id names to the elements dynamically using DOM manipulation. 
// The start and stop numbers must be validated to be at least 200 apart and no more than 10,000 apart. 
// You also will implement input validation to verify that only positive numbers are entered and that the start number is less than the stop number. 
// There will be 40 numbers on each line, except the last line. 
// The numbers printed to the browser page must be formatted correctly (12,453) 
// Every “Sweet”, “Salty”, and “SweetnSalty” printed must have a green background with white text.  
// You will have small, red text that pops up under the input box to explain what the user did wrong while presenting that step again. 
// After printing the numbers to the screen, you will allow the user to click a ‘Reset’ button to erase everything and do it all again.  
//#endregion{};