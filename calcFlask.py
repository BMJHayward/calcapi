''' run with:
$ export FLASK_APP=calcFlask.py
$ export FLASK_ENV=development
$ flask run
'''

from flask import Flask
from flask import jsonify
app = Flask(__name__)

@app.route('/')
def operations():
    return ''

@app.route('/add')
@app.route('/add/<int:left>')
@app.route('/add/<int:left>/<int:right>')
def sum(left=0, right=0):
    return jsonify(operation='add', args=[left, right], result=left + right)

@app.route('/sub')
@app.route('/sub/<int:left>')
@app.route('/sub/<int:left>/<int:right>')
def sub(left=0, right=0):
    return jsonify(operation='subtract', args=[left, right], result=left - right)

@app.route('/mul')
@app.route('/mul/<int:left>')
@app.route('/mul/<int:left>/<int:right>')
def mul(left=1, right=1):
    return jsonify(operation='multiply', args=[left, right], result=left * right)

@app.route('/div')
@app.route('/div/<int:left>')
@app.route('/div/<int:left>/<int:right>')
def div(left=1, right=1):
    return jsonify(operation='divide', args=[left, right], result=left / right)
    