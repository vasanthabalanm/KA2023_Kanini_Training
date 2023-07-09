import './App.css';
import Expenses from './Components/Expenses'; 

function App() {


  const addnewexpense = (event)=>{
    event.preventdefault()
  }
  const expense =[
    {expdate : new Date(2018,9,8),expensess:"food",amount:3000,}
  ];
  return (
    <div className="App">
      welcome to react
      <p>Date         Expense       Amount</p>
      <Expenses
        expdate ={expense[0].expdate}
        exexpen ={expense[0].expensess}
        examount ={expense[0].amount}
      ></Expenses>
    </div>
  );
}

export default App;
