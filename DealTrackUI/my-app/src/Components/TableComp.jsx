import React, { Component } from 'react';
import { Button } from 'react-bootstrap';
import axios from 'axios';

class TableComponent extends Component {
    render() { 
        if(this.props.dealTrackData){
            return <table>
            {this.state.dealTrackData.map((item =>
            <tr key={item.DealNumber}>{item.CustomerName}</tr>
            ))}
          </table>
        }
    }
}
 
export default TableComponent ;