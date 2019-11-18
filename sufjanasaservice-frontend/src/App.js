import React, { Component } from 'react';
import Header from './Header';
import Lyrics from './Lyrics';
import './App.css'

class App extends Component {
    constructor() {
        super();
        this.state = {
            lyrics: [ "" ],
            title: "",
        }
    }

    componentDidMount() {
        fetch("https://mastrchef.rocks/api/sufjan")
        .then(result => {
            return result.text();    
        })
        .then(result => {
            var lines = []
            result.split('\n').forEach(function(item){
                lines.push(<p>{item}</p>)
            });

            this.setState({lyrics: lines, title: lines[Math.floor(Math.random()*lines.length)]})
        });
    }

    render() {
        return (
            <jsxFragment>
                <Header title={this.state.title} />
                <hr style={{width: "60vw"}} />
                <Lyrics lyrics={this.state.lyrics} />
                <div id="buttonDiv">
                    <button type="button" class="btn btn-light" onClick={() => this.componentDidMount()}>
                        Don't like it? Forget this one forever and get a new one.
                    </button>
                </div>
            </jsxFragment>
        )
    }
}

export default App