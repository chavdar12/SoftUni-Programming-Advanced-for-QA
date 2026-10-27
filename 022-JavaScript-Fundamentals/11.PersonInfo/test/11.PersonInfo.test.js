import { expect } from 'chai';
import { solve as personInfo } from '../11.PersonInfo.js';

describe('11.PersonInfo', () => {
    it('11 builds a person object', () => {
        expect(personInfo('Peter', 'Pan', '20')).to.deep.equal({ firstName: 'Peter', lastName: 'Pan', age: '20' });
    });
});
