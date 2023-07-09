import React from 'react';
import './ExpenseDateLoad.css';

const ExpenseDateLoad = (props) =>
{
    const day = props.expdate.toLocaleString("en-US", {day:"2-digit"});
    const month = props.expdate.toLocaleString("en-US", {month:'long'});
    const year = props.expdate.getFullYear();
    return (
        <div class="expensedate">
            <div class="expensedate-day">{day}</div>
            <div class="expensedate-month">{month}</div>
            <div class="expensedate-year">{year}</div>
        </div>
    )
}


export default ExpenseDateLoad;