// Put your code here
const allSpells = [
    {
        name : "Turn enemy into a newt",
                    isEvil : true,
                    energyReqired : 5.1
                },
                {
                    name : "Conjure some gold for a local charity",
                    isEvil : false,
                    energyReqired : 2.99
                },
                {
                    name : "Give a deaf person the ability to heal",
                    isEvil : false,
                    energyReqired : 12.2
                },
                {
                    name : "Make yourself emperor of the universe",
                    isEvil : true,
                    energyReqired : 100.0
                },
                {
                    name : "Convince your relatives your political views are correct",
                    isEvil : false,
                    energyReqired : 2921.5
                }
            ]

    console.log("Do you believe in magic?")
    console.log("------------------------")

    
    const MakeEvilSpellBook = () =>
    {
        const evilSpellBook = allSpells.filter(!spell.isEvil);
        const evilBook = {};
        evilBook.Title = "Evil Book",
        evilBook.Spells = evilSpellBook
        
        return evilBook
    }
    
    const MakeGoodSpellBook = () =>
    {
        const goodSpellBook = allSpells.filter(spell.isEvil);
        const goodBook = {};
        goodBook.Title = "Good Book",
        goodBook.Spells = goodSpellBook
        
        return goodBook
}

const DisplaySpellBook = (book) =>
{
    console.log(book.Title);
    for (Spell in book.Spells)
    {
        console.log(`  ${Spell.Name}`);
    }
}

DisplaySpellBook(goodBook);
console.log();
DisplaySpellBook(evilBook);

        

