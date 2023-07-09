import React from 'react';
import ExpenseForm from './ExpenseForm';

const NewExpense = (props) =>{
    const AddNewExpense  = (newExpense) => {
        const newExpenses = {...newExpense};
        console.log(newExpenses);
        props.onAddNewExpense(newExpenses)
    };
    return(
        <ExpenseForm onAddNewExpense = {AddNewExpense}>

        </ExpenseForm>
    );
}


export default NewExpense;