function doStuff(){
    var rotateDegrees = 0;
    var ul = document.getElementById('Greetings');

    var friends = ['Ray', 'Oscar', 'Gwen', 'Bob', 'Marie'];

    var shuffledFriends = shuffle(friends);

    for(var i = 0; i < shuffledFriends.length; ++i){
        var li = document.createElement('li');
        
        li.innerHTML = `Hello ${shuffledFriends[i]}`;
        li.classList = shuffledFriends[i];
        li.style.fontSize = "xx-large";
        li.style.transform = `rotate(${rotateDegrees}deg) translateX(${rotateDegrees * 5}px)`;

        ul.appendChild(li);
        rotateDegrees += 5;
    }
}

function shuffle(array) {
    var currentIndex = array.length, temporaryValue, randomIndex;
  
   while (0 !== currentIndex) {
  
      randomIndex = Math.floor(Math.random() * currentIndex);
      currentIndex -= 1;
  
      temporaryValue = array[currentIndex];
      array[currentIndex] = array[randomIndex];
      array[randomIndex] = temporaryValue;
    }
  
    return array;
  }