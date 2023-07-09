import ExpenseDateLoad from "./ExpenseDateLoad";
import "./Expenses.css"

function Expenses (props){
    return(
        <div>
            {props.expdate}
            <div>
            <ExpenseDateLoad
            expdate = {props.expdate}
            >
            
            </ExpenseDateLoad>  
            </div>
            
        </div>
    );
}
export default Expenses;