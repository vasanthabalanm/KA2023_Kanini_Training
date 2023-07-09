import React from 'react';
import Expenses from './components/Expenses/Expenses';
import './App.css'
import NewExpense from './components/Expenses/NewExpense';
import ControlledConter from './components/Additionals/ControlledConter';
import BoundedComponent from './components/Additionals/BoundedComponent';
import Modulehandling from './components/Additionals/Modulehandling';
import Header from './components/Additionals/Header';
import Footer from './components/Additionals/Footer';
import Hooksexample from './components/Additionals/Hooksexample';
import Hooksmessage from './components/Additionals/Hooksmessage';

function App() {

  // expenses -> helper constants
  const expenses = [
    { edate:new Date(2023, 5, 19), expname: 'Groceries', expamount: 1000 },
    { edate:new Date(2023, 6, 19), expname: 'Food', expamount: 2000 }
  ];

  const AddExpense  = (newExpense) => {
    const newExpenes = {...newExpense};
    console.log(newExpenes);
};
  return (
    <div className='content'>
      <div>
        <h1>React Learning</h1> <h2>React Example</h2>
      </div>
      <h4>Expenses List</h4>
      <NewExpense  onAddNewExpense = {AddExpense}></NewExpense>
      <p>Expense      Amount     Date</p>
      <Expenses
        expdate={expenses[0].edate}
        exptype={expenses[0].expname}
        expamt={expenses[0].expamount}
      ></Expenses>

      <Expenses
        expdate={expenses[1].edate}
        exptype={expenses[1].expname}
        expamt={expenses[1].expamount}
      ></Expenses>



      {/* conterlledcounter */}
      <ControlledConter/>



      {/* bounded controller */}
      <BoundedComponent/>


      {/* moudle handling */}
      <Modulehandling/>


      {/* hooks exapmle */}
      <Hooksexample/>

      {/* hooksmessage */}
      <Hooksmessage/>


      <br></br>
      <br></br>
      <Header/>
      <br></br>
      <br></br>

      <br></br>
      <br></br>
      <Footer/>
    </div>
  );
}

export default App;
