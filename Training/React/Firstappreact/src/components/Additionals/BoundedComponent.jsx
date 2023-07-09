import React from 'react'

// const BoundedComponent = () => {

class BoundedComponent extends React.Component {
    constructor(props) {
        super(props);
        this.state = { count: 0 };
        this.count = this.count.bind(this)
    }

    count = () => {
        this.setState((prestate => ({
            count: prestate.count + 1
        })));
    }
    render(){
        return(
            <div className = "div" >
                <div>BoundedComponent</div>
                <p>count the clicks:{this.state.count}</p>
                <button onClick={this.count}>Click</button>
            </div>
        );
    }
   
};

export default BoundedComponent