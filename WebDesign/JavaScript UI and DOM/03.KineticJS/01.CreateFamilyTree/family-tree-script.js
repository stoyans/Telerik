var familyMembers = [
    {
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova', 'Peter Petrov']
    },
    {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Teodor Stamatov', 'Boris Opanov', 'Maria Petrova']
    },
    {
        mother: 'Boriana Stamatova',
        father: 'Teodor Stamatov',
        children: ['Martin Stamatov', 'Albena Dimitrova']
    },
    {
        mother: 'Albena Dimitrova',
        father: 'Ivan Dimitrov',
        children: ['Doncho Dimitrov', 'Ivaylo Dimitrov']
    },
    {
        mother: 'Donika Dimitrova',
        father: 'Doncho Dimitrov',
        children: ['Vladimir Dimitrov', 'Iliana Dobreva']
    },
    {
        mother: 'Juliana Petrova',
        father: 'Peter Petrov',
        children: ['Dimitar Petrov', 'Galina Opanova']
    },
    {
        mother: 'Iliana Dobreva',
        father: 'Delian Dobrev',
        children: ['Dimitar Dobrev', 'Galina Pundiova']
    },
    {
        mother: 'Galina Pundiova',
        father: 'Martin Pundiov',
        children: ['Dimitar Pundiov', 'Todor Pundiov']
    },
    {
        mother: 'Maria Pundiova',
        father: 'Dimitar Pundiov',
        children: ['Georgi Pundiov', 'Stoian Pundiov']
    },
    {
        mother: 'Dobrinka Pundiova',
        father: 'Georgi Pundiov',
        children: ['Pavel Pundiov', 'Marian Pundiov']
    },
    {
        mother: 'Elena Pundiova',
        father: 'Marian Pundiov',
        children: ['Kamen Pundiov', 'Hristina Ivancheva']
    },
    {
        mother: 'Hristina Ivancheva',
        father: 'Martin Ivanchev',
        children: ['Kamen Ivanchev', 'Evgeny Ivanchev']
    },
    {
        mother: 'Maria Ivancheva',
        father: 'Kamen Ivanchev',
        children: ['Ivo Ivanchev', 'Delian Ivanchev']
    },
    {
        mother: 'Nadejda Ivancheva',
        father: 'Ivo Ivanchev',
        children: ['Petio Ivanchev', 'Marin Ivanchev']
    },
    {
        mother: 'Natalia Ivancheva',
        father: 'Delian Ivanchev',
        children: ['Galina Hristova']
    },
    {
        mother: 'Galina Opanova',
        father: 'Boian Opanov',
        children: ['Maria Opanova', 'Patar Opanov']
    },
    {
        mother: 'Galina Hristova',
        father: 'Marin Hristov',
        children: ['Petar Hristov', 'Kamen Hristov', 'Ivan Hristov']
    },
    {
        mother: 'Simona Hristova',
        father: 'Kamen Hristov',
        children: ['Elena Hristova', 'Valeria Hristova']
    }
];
var familiesWithChildren = [];

function findRoot(family) {
    var rootFamilyNames = '';
    var rootMotherName = '';
    var rootFatherName = '';

    for (var i = 0; i < family.length; i++) {
        rootMotherName = family[i].mother;
        rootFatherName = family[i].father;

        var fatherNameCount = 1;
        var motherNameCount = 1;

        for (var k = 0; k < family.length; k++) {

            for (var j = 0; j < family[k].children.length; j++) {
                var currentChild = family[k].children[j];
                if (currentChild === rootMotherName) {
                    motherNameCount++;
                }
                if (currentChild === rootFatherName) {
                    fatherNameCount++;
                }
            }
        }
        if (motherNameCount === 1 && fatherNameCount === 1) {
            rootFamilyNames = rootMotherName + ' ' + rootFatherName;
            familiesWithChildren.push(i);
            break;
        }
    }

    return rootFamilyNames;
}

function treeSearch(familiesWithChildren) {

    var isMarried = false;
    var subfamilies = [];
    var resultLevel = [];

    var currentLevelofMembers = '';

    for (var i = 0; i < familiesWithChildren.length; i++) {

        var currentFamilyIndex = familiesWithChildren[i];
        
        for (var k = 0; k < familyMembers[currentFamilyIndex].children.length; k++) {
            isMarried = false;
            var currentChild = familyMembers[currentFamilyIndex].children[k];
            for (var j = 0; j < familyMembers.length; j++) {
                if (currentChild === familyMembers[j].mother) {
                    currentLevelofMembers += familyMembers[j].father + '+' + currentChild + ' ';
                    subfamilies.push(j);
                    isMarried = true;
                }
                if (currentChild === familyMembers[j].father) {
                    currentLevelofMembers += currentChild + '+' + familyMembers[j].mother + ' ';
                    subfamilies.push(j);
                    isMarried = true;
                }
            }
            if (isMarried === false) {
                currentLevelofMembers += currentChild + ' ';
            }
        }
        if (i === familiesWithChildren.length - 1) {
            
            console.log(currentLevelofMembers);
            resultLevel.push(currentLevelofMembers);
            currentLevelofMembers = '';
            familiesWithChildren = [];
            familiesWithChildren = subfamilies;
            subfamilies = [];
            i = -1;
        }
    }
    return resultLevel;
}

console.log(findRoot(familyMembers));
treeSearch(familiesWithChildren);

var text = ["aaaaaa", "dawdww", "dad"]
var stage = new Kinetic.Stage({
    container: 'container',
    width: 2000,
    height:2000
});

var layer = new Kinetic.Layer();

for (var i = 0; i < text.length ; i++) {
    var y = i;
    var text = new Kinetic.Text(
        {
            x: 0,
            y: y + 10,
            text: text[i] + '\n' + text[i + 1],
            fontSize: 20,
            fontFamily: 'Calibri',
            fill: 'green',
            width: 500,
            height: 500
        }
        );
}

//var rect = new Kinetic.Rect(
//    {
//        x: 50,
//        y: 50,
//        width: 2000,
//        height: 2000,
//        fill: 'orange',
//        stroke: 'green'
//    }
//    );

//layer.add(rect);
layer.add(text);
stage.add(layer);