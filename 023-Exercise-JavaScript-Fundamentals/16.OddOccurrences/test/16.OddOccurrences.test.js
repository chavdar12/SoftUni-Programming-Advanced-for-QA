import { expect } from 'chai';
import { solve as oddOccurrences } from '../16.OddOccurrences.js';

describe('16.OddOccurrences', () => {
    it('16 returns odd-occurrence words in first-seen order', () => {
        expect(oddOccurrences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')).to.equal('c# php 1 5');
        expect(oddOccurrences('Cake IS SWEET is Soft CAKE sweet Food')).to.equal('soft food');
    });
});
