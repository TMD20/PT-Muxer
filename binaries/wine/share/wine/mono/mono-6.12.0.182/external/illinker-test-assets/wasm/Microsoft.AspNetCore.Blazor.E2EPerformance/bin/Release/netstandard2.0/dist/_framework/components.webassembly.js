/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./Boot.WebAssembly.ts");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./Boot.WebAssembly.ts":
/*!*****************************!*\
  !*** ./Boot.WebAssembly.ts ***!
  \*****************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
Object.defineProperty(exports, "__esModule", { value: true });
__webpack_require__(/*! @dotnet/jsinterop */ "./node_modules/@dotnet/jsinterop/dist/Microsoft.JSInterop.js");
__webpack_require__(/*! ./GlobalExports */ "./GlobalExports.ts");
var Environment = __webpack_require__(/*! ./Environment */ "./Environment.ts");
var MonoPlatform_1 = __webpack_require__(/*! ./Platform/Mono/MonoPlatform */ "./Platform/Mono/MonoPlatform.ts");
var Url_1 = __webpack_require__(/*! ./Platform/Url */ "./Platform/Url.ts");
var Renderer_1 = __webpack_require__(/*! ./Rendering/Renderer */ "./Rendering/Renderer.ts");
var SharedMemoryRenderBatch_1 = __webpack_require__(/*! ./Rendering/RenderBatch/SharedMemoryRenderBatch */ "./Rendering/RenderBatch/SharedMemoryRenderBatch.ts");
var BootCommon_1 = __webpack_require__(/*! ./BootCommon */ "./BootCommon.ts");
function boot() {
    return __awaiter(this, void 0, void 0, function () {
        var platform, bootConfig, embeddedResourcesPromise, loadAssemblyUrls, ex_1, mainAssemblyName;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    platform = Environment.setPlatform(MonoPlatform_1.monoPlatform);
                    window['Blazor'].platform = platform;
                    window['Blazor']._internal.renderBatch = function (browserRendererId, batchAddress) {
                        Renderer_1.renderBatch(browserRendererId, new SharedMemoryRenderBatch_1.SharedMemoryRenderBatch(batchAddress));
                    };
                    return [4 /*yield*/, BootCommon_1.fetchBootConfigAsync()];
                case 1:
                    bootConfig = _a.sent();
                    embeddedResourcesPromise = BootCommon_1.loadEmbeddedResourcesAsync(bootConfig);
                    if (!bootConfig.linkerEnabled) {
                        console.info('Blazor is running in dev mode without IL stripping. To make the bundle size significantly smaller, publish the application or see https://go.microsoft.com/fwlink/?linkid=870414');
                    }
                    loadAssemblyUrls = [bootConfig.main]
                        .concat(bootConfig.assemblyReferences)
                        .map(function (filename) { return "_framework/_bin/" + filename; });
                    _a.label = 2;
                case 2:
                    _a.trys.push([2, 4, , 5]);
                    return [4 /*yield*/, platform.start(loadAssemblyUrls)];
                case 3:
                    _a.sent();
                    return [3 /*break*/, 5];
                case 4:
                    ex_1 = _a.sent();
                    throw new Error("Failed to start platform. Reason: " + ex_1);
                case 5: 
                // Before we start running .NET code, be sure embedded content resources are all loaded
                return [4 /*yield*/, embeddedResourcesPromise];
                case 6:
                    // Before we start running .NET code, be sure embedded content resources are all loaded
                    _a.sent();
                    mainAssemblyName = Url_1.getAssemblyNameFromUrl(bootConfig.main);
                    platform.callEntryPoint(mainAssemblyName, bootConfig.entryPoint, []);
                    return [2 /*return*/];
            }
        });
    });
}
boot();


/***/ }),

/***/ "./BootCommon.ts":
/*!***********************!*\
  !*** ./BootCommon.ts ***!
  \***********************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
Object.defineProperty(exports, "__esModule", { value: true });
function fetchBootConfigAsync() {
    return __awaiter(this, void 0, void 0, function () {
        var bootConfigResponse;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch('_framework/blazor.boot.json', { method: 'Get', credentials: 'include' })];
                case 1:
                    bootConfigResponse = _a.sent();
                    return [2 /*return*/, bootConfigResponse.json()];
            }
        });
    });
}
exports.fetchBootConfigAsync = fetchBootConfigAsync;
function loadEmbeddedResourcesAsync(bootConfig) {
    var cssLoadingPromises = bootConfig.cssReferences.map(function (cssReference) {
        var linkElement = document.createElement('link');
        linkElement.rel = 'stylesheet';
        linkElement.href = cssReference;
        return loadResourceFromElement(linkElement);
    });
    var jsLoadingPromises = bootConfig.jsReferences.map(function (jsReference) {
        var scriptElement = document.createElement('script');
        scriptElement.src = jsReference;
        return loadResourceFromElement(scriptElement);
    });
    return Promise.all(cssLoadingPromises.concat(jsLoadingPromises));
}
exports.loadEmbeddedResourcesAsync = loadEmbeddedResourcesAsync;
function loadResourceFromElement(element) {
    return new Promise(function (resolve, reject) {
        element.onload = resolve;
        element.onerror = reject;
        document.head.appendChild(element);
    });
}


/***/ }),

/***/ "./Environment.ts":
/*!************************!*\
  !*** ./Environment.ts ***!
  \************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
function setPlatform(platformInstance) {
    exports.platform = platformInstance;
    return exports.platform;
}
exports.setPlatform = setPlatform;


/***/ }),

/***/ "./GlobalExports.ts":
/*!**************************!*\
  !*** ./GlobalExports.ts ***!
  \**************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var UriHelper_1 = __webpack_require__(/*! ./Services/UriHelper */ "./Services/UriHelper.ts");
var Http_1 = __webpack_require__(/*! ./Services/Http */ "./Services/Http.ts");
var Renderer_1 = __webpack_require__(/*! ./Rendering/Renderer */ "./Rendering/Renderer.ts");
// Make the following APIs available in global scope for invocation from JS
window['Blazor'] = {
    navigateTo: UriHelper_1.navigateTo,
    _internal: {
        attachRootComponentToElement: Renderer_1.attachRootComponentToElement,
        http: Http_1.internalFunctions,
        uriHelper: UriHelper_1.internalFunctions
    }
};


/***/ }),

/***/ "./Platform/Mono/MonoDebugger.ts":
/*!***************************************!*\
  !*** ./Platform/Mono/MonoDebugger.ts ***!
  \***************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var Url_1 = __webpack_require__(/*! ../Url */ "./Platform/Url.ts");
var currentBrowserIsChrome = window.chrome
    && navigator.userAgent.indexOf('Edge') < 0; // Edge pretends to be Chrome
var hasReferencedPdbs = false;
function hasDebuggingEnabled() {
    return hasReferencedPdbs && currentBrowserIsChrome;
}
exports.hasDebuggingEnabled = hasDebuggingEnabled;
function attachDebuggerHotkey(loadAssemblyUrls) {
    hasReferencedPdbs = loadAssemblyUrls
        .some(function (url) { return /\.pdb$/.test(Url_1.getFileNameFromUrl(url)); });
    // Use the combination shift+alt+D because it isn't used by the major browsers
    // for anything else by default
    var altKeyName = navigator.platform.match(/^Mac/i) ? 'Cmd' : 'Alt';
    if (hasDebuggingEnabled()) {
        console.info("Debugging hotkey: Shift+" + altKeyName + "+D (when application has focus)");
    }
    // Even if debugging isn't enabled, we register the hotkey so we can report why it's not enabled
    document.addEventListener('keydown', function (evt) {
        if (evt.shiftKey && (evt.metaKey || evt.altKey) && evt.code === 'KeyD') {
            if (!hasReferencedPdbs) {
                console.error('Cannot start debugging, because the application was not compiled with debugging enabled.');
            }
            else if (!currentBrowserIsChrome) {
                console.error('Currently, only Chrome is supported for debugging.');
            }
            else {
                launchDebugger();
            }
        }
    });
}
exports.attachDebuggerHotkey = attachDebuggerHotkey;
function launchDebugger() {
    // The noopener flag is essential, because otherwise Chrome tracks the association with the
    // parent tab, and then when the parent tab pauses in the debugger, the child tab does so
    // too (even if it's since navigated to a different page). This means that the debugger
    // itself freezes, and not just the page being debugged.
    //
    // We have to construct a link element and simulate a click on it, because the more obvious
    // window.open(..., 'noopener') always opens a new window instead of a new tab.
    var link = document.createElement('a');
    link.href = "_framework/debug?url=" + encodeURIComponent(location.href);
    link.target = '_blank';
    link.rel = 'noopener noreferrer';
    link.click();
}


/***/ }),

/***/ "./Platform/Mono/MonoPlatform.ts":
/*!***************************************!*\
  !*** ./Platform/Mono/MonoPlatform.ts ***!
  \***************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var Url_1 = __webpack_require__(/*! ../Url */ "./Platform/Url.ts");
var MonoDebugger_1 = __webpack_require__(/*! ./MonoDebugger */ "./Platform/Mono/MonoDebugger.ts");
var assemblyHandleCache = {};
var typeHandleCache = {};
var methodHandleCache = {};
var assembly_load;
var find_class;
var find_method;
var invoke_method;
var mono_string_get_utf8;
var mono_string;
var appBinDirName = 'appBinDir';
exports.monoPlatform = {
    start: function start(loadAssemblyUrls) {
        return new Promise(function (resolve, reject) {
            MonoDebugger_1.attachDebuggerHotkey(loadAssemblyUrls);
            // mono.js assumes the existence of this
            window['Browser'] = {
                init: function () { }
            };
            // Emscripten works by expecting the module config to be a global
            window['Module'] = createEmscriptenModuleInstance(loadAssemblyUrls, resolve, reject);
            addScriptTagsToDocument();
        });
    },
    findMethod: findMethod,
    callEntryPoint: function callEntryPoint(assemblyName, entrypointMethod, args) {
        // Parse the entrypointMethod, which is of the form MyApp.MyNamespace.MyTypeName::MyMethodName
        // Note that we don't support specifying a method overload, so it has to be unique
        var entrypointSegments = entrypointMethod.split('::');
        if (entrypointSegments.length != 2) {
            throw new Error('Malformed entry point method name; could not resolve class name and method name.');
        }
        var typeFullName = entrypointSegments[0];
        var methodName = entrypointSegments[1];
        var lastDot = typeFullName.lastIndexOf('.');
        var namespace = lastDot > -1 ? typeFullName.substring(0, lastDot) : '';
        var typeShortName = lastDot > -1 ? typeFullName.substring(lastDot + 1) : typeFullName;
        var entryPointMethodHandle = exports.monoPlatform.findMethod(assemblyName, namespace, typeShortName, methodName);
        exports.monoPlatform.callMethod(entryPointMethodHandle, null, args);
    },
    callMethod: function callMethod(method, target, args) {
        if (args.length > 4) {
            // Hopefully this restriction can be eased soon, but for now make it clear what's going on
            throw new Error("Currently, MonoPlatform supports passing a maximum of 4 arguments from JS to .NET. You tried to pass " + args.length + ".");
        }
        var stack = Module.stackSave();
        try {
            var argsBuffer = Module.stackAlloc(args.length);
            var exceptionFlagManagedInt = Module.stackAlloc(4);
            for (var i = 0; i < args.length; ++i) {
                Module.setValue(argsBuffer + i * 4, args[i], 'i32');
            }
            Module.setValue(exceptionFlagManagedInt, 0, 'i32');
            var res = invoke_method(method, target, argsBuffer, exceptionFlagManagedInt);
            if (Module.getValue(exceptionFlagManagedInt, 'i32') !== 0) {
                // If the exception flag is set, the returned value is exception.ToString()
                throw new Error(exports.monoPlatform.toJavaScriptString(res));
            }
            return res;
        }
        finally {
            Module.stackRestore(stack);
        }
    },
    toJavaScriptString: function toJavaScriptString(managedString) {
        // Comments from original Mono sample:
        //FIXME this is wastefull, we could remove the temp malloc by going the UTF16 route
        //FIXME this is unsafe, cuz raw objects could be GC'd.
        var utf8 = mono_string_get_utf8(managedString);
        var res = Module.UTF8ToString(utf8);
        Module._free(utf8);
        return res;
    },
    toDotNetString: function toDotNetString(jsString) {
        return mono_string(jsString);
    },
    toUint8Array: function toUint8Array(array) {
        var dataPtr = getArrayDataPointer(array);
        var length = Module.getValue(dataPtr, 'i32');
        return new Uint8Array(Module.HEAPU8.buffer, dataPtr + 4, length);
    },
    getArrayLength: function getArrayLength(array) {
        return Module.getValue(getArrayDataPointer(array), 'i32');
    },
    getArrayEntryPtr: function getArrayEntryPtr(array, index, itemSize) {
        // First byte is array length, followed by entries
        var address = getArrayDataPointer(array) + 4 + index * itemSize;
        return address;
    },
    getObjectFieldsBaseAddress: function getObjectFieldsBaseAddress(referenceTypedObject) {
        // The first two int32 values are internal Mono data
        return (referenceTypedObject + 8);
    },
    readInt32Field: function readHeapInt32(baseAddress, fieldOffset) {
        return Module.getValue(baseAddress + (fieldOffset || 0), 'i32');
    },
    readFloatField: function readHeapFloat(baseAddress, fieldOffset) {
        return Module.getValue(baseAddress + (fieldOffset || 0), 'float');
    },
    readObjectField: function readHeapObject(baseAddress, fieldOffset) {
        return Module.getValue(baseAddress + (fieldOffset || 0), 'i32');
    },
    readStringField: function readHeapObject(baseAddress, fieldOffset) {
        var fieldValue = Module.getValue(baseAddress + (fieldOffset || 0), 'i32');
        return fieldValue === 0 ? null : exports.monoPlatform.toJavaScriptString(fieldValue);
    },
    readStructField: function readStructField(baseAddress, fieldOffset) {
        return (baseAddress + (fieldOffset || 0));
    },
};
function findAssembly(assemblyName) {
    var assemblyHandle = assemblyHandleCache[assemblyName];
    if (!assemblyHandle) {
        assemblyHandle = assembly_load(assemblyName);
        if (!assemblyHandle) {
            throw new Error("Could not find assembly \"" + assemblyName + "\"");
        }
        assemblyHandleCache[assemblyName] = assemblyHandle;
    }
    return assemblyHandle;
}
function findType(assemblyName, namespace, className) {
    var fullyQualifiedTypeName = "[" + assemblyName + "]" + namespace + "." + className;
    var typeHandle = typeHandleCache[fullyQualifiedTypeName];
    if (!typeHandle) {
        typeHandle = find_class(findAssembly(assemblyName), namespace, className);
        if (!typeHandle) {
            throw new Error("Could not find type \"" + className + "\" in namespace \"" + namespace + "\" in assembly \"" + assemblyName + "\"");
        }
        typeHandleCache[fullyQualifiedTypeName] = typeHandle;
    }
    return typeHandle;
}
function findMethod(assemblyName, namespace, className, methodName) {
    var fullyQualifiedMethodName = "[" + assemblyName + "]" + namespace + "." + className + "::" + methodName;
    var methodHandle = methodHandleCache[fullyQualifiedMethodName];
    if (!methodHandle) {
        methodHandle = find_method(findType(assemblyName, namespace, className), methodName, -1);
        if (!methodHandle) {
            throw new Error("Could not find method \"" + methodName + "\" on type \"" + namespace + "." + className + "\"");
        }
        methodHandleCache[fullyQualifiedMethodName] = methodHandle;
    }
    return methodHandle;
}
function addScriptTagsToDocument() {
    var browserSupportsNativeWebAssembly = typeof WebAssembly !== 'undefined' && WebAssembly.validate;
    if (!browserSupportsNativeWebAssembly) {
        throw new Error('This browser does not support WebAssembly.');
    }
    var scriptElem = document.createElement('script');
    scriptElem.src = '_framework/wasm/mono.js';
    scriptElem.defer = true;
    document.body.appendChild(scriptElem);
}
function createEmscriptenModuleInstance(loadAssemblyUrls, onReady, onError) {
    var module = {};
    var wasmBinaryFile = '_framework/wasm/mono.wasm';
    var suppressMessages = ['DEBUGGING ENABLED'];
    module.print = function (line) { return (suppressMessages.indexOf(line) < 0 && console.log("WASM: " + line)); };
    module.printErr = function (line) { return console.error("WASM: " + line); };
    module.preRun = [];
    module.postRun = [];
    module.preloadPlugins = [];
    module.locateFile = function (fileName) {
        switch (fileName) {
            case 'mono.wasm': return wasmBinaryFile;
            default: return fileName;
        }
    };
    module.preRun.push(function () {
        // By now, emscripten should be initialised enough that we can capture these methods for later use
        var mono_wasm_add_assembly = Module.cwrap('mono_wasm_add_assembly', null, ['string', 'number', 'number']);
        assembly_load = Module.cwrap('mono_wasm_assembly_load', 'number', ['string']);
        find_class = Module.cwrap('mono_wasm_assembly_find_class', 'number', ['number', 'string', 'string']);
        find_method = Module.cwrap('mono_wasm_assembly_find_method', 'number', ['number', 'string', 'number']);
        invoke_method = Module.cwrap('mono_wasm_invoke_method', 'number', ['number', 'number', 'number']);
        mono_string_get_utf8 = Module.cwrap('mono_wasm_string_get_utf8', 'number', ['number']);
        mono_string = Module.cwrap('mono_wasm_string_from_js', 'number', ['string']);
        MONO.loaded_files = [];
        loadAssemblyUrls.forEach(function (url) {
            var filename = Url_1.getFileNameFromUrl(url);
            var runDependencyId = "blazor:" + filename;
            addRunDependency(runDependencyId);
            asyncLoad(url).then(function (data) {
                var heapAddress = Module._malloc(data.length);
                var heapMemory = new Uint8Array(Module.HEAPU8.buffer, heapAddress, data.length);
                heapMemory.set(data);
                mono_wasm_add_assembly(filename, heapAddress, data.length);
                MONO.loaded_files.push(toAbsoluteUrl(url));
                removeRunDependency(runDependencyId);
            }, function (errorInfo) {
                // If it's a 404 on a .pdb, we don't want to block the app from starting up.
                // We'll just skip that file and continue (though the 404 is logged in the console).
                // This happens if you build a Debug build but then run in Production environment.
                var isPdb404 = errorInfo instanceof XMLHttpRequest
                    && errorInfo.status === 404
                    && filename.match(/\.pdb$/);
                if (!isPdb404) {
                    onError(errorInfo);
                }
                removeRunDependency(runDependencyId);
            });
        });
    });
    module.postRun.push(function () {
        var load_runtime = Module.cwrap('mono_wasm_load_runtime', null, ['string', 'number']);
        load_runtime(appBinDirName, MonoDebugger_1.hasDebuggingEnabled() ? 1 : 0);
        MONO.mono_wasm_runtime_is_ready = true;
        attachInteropInvoker();
        onReady();
    });
    return module;
}
var anchorTagForAbsoluteUrlConversions = document.createElement('a');
function toAbsoluteUrl(possiblyRelativeUrl) {
    anchorTagForAbsoluteUrlConversions.href = possiblyRelativeUrl;
    return anchorTagForAbsoluteUrlConversions.href;
}
function asyncLoad(url) {
    return new Promise(function (resolve, reject) {
        var xhr = new XMLHttpRequest;
        xhr.open('GET', url, /* async: */ true);
        xhr.responseType = 'arraybuffer';
        xhr.onload = function xhr_onload() {
            if (xhr.status == 200 || xhr.status == 0 && xhr.response) {
                var asm = new Uint8Array(xhr.response);
                resolve(asm);
            }
            else {
                reject(xhr);
            }
        };
        xhr.onerror = reject;
        xhr.send(undefined);
    });
}
function getArrayDataPointer(array) {
    return array + 12; // First byte from here is length, then following bytes are entries
}
function attachInteropInvoker() {
    var dotNetDispatcherInvokeMethodHandle = findMethod('Mono.WebAssembly.Interop', 'Mono.WebAssembly.Interop', 'MonoWebAssemblyJSRuntime', 'InvokeDotNet');
    var dotNetDispatcherBeginInvokeMethodHandle = findMethod('Mono.WebAssembly.Interop', 'Mono.WebAssembly.Interop', 'MonoWebAssemblyJSRuntime', 'BeginInvokeDotNet');
    DotNet.attachDispatcher({
        beginInvokeDotNetFromJS: function (callId, assemblyName, methodIdentifier, dotNetObjectId, argsJson) {
            // As a current limitation, we can only pass 4 args. Fortunately we only need one of
            // 'assemblyName' or 'dotNetObjectId', so overload them in a single slot
            var assemblyNameOrDotNetObjectId = dotNetObjectId
                ? dotNetObjectId.toString()
                : assemblyName;
            exports.monoPlatform.callMethod(dotNetDispatcherBeginInvokeMethodHandle, null, [
                callId ? exports.monoPlatform.toDotNetString(callId.toString()) : null,
                exports.monoPlatform.toDotNetString(assemblyNameOrDotNetObjectId),
                exports.monoPlatform.toDotNetString(methodIdentifier),
                exports.monoPlatform.toDotNetString(argsJson)
            ]);
        },
        invokeDotNetFromJS: function (assemblyName, methodIdentifier, dotNetObjectId, argsJson) {
            var resultJsonStringPtr = exports.monoPlatform.callMethod(dotNetDispatcherInvokeMethodHandle, null, [
                assemblyName ? exports.monoPlatform.toDotNetString(assemblyName) : null,
                exports.monoPlatform.toDotNetString(methodIdentifier),
                dotNetObjectId ? exports.monoPlatform.toDotNetString(dotNetObjectId.toString()) : null,
                exports.monoPlatform.toDotNetString(argsJson)
            ]);
            return resultJsonStringPtr
                ? exports.monoPlatform.toJavaScriptString(resultJsonStringPtr)
                : null;
        },
    });
}


/***/ }),

/***/ "./Platform/Url.ts":
/*!*************************!*\
  !*** ./Platform/Url.ts ***!
  \*************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
function getFileNameFromUrl(url) {
    // This could also be called "get last path segment from URL", but the primary
    // use case is to extract things that look like filenames
    var lastSegment = url.substring(url.lastIndexOf('/') + 1);
    var queryStringStartPos = lastSegment.indexOf('?');
    return queryStringStartPos < 0 ? lastSegment : lastSegment.substring(0, queryStringStartPos);
}
exports.getFileNameFromUrl = getFileNameFromUrl;
function getAssemblyNameFromUrl(url) {
    return getFileNameFromUrl(url).replace(/\.dll$/, '');
}
exports.getAssemblyNameFromUrl = getAssemblyNameFromUrl;


/***/ }),

/***/ "./Rendering/BrowserRenderer.ts":
/*!**************************************!*\
  !*** ./Rendering/BrowserRenderer.ts ***!
  \**************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var RenderBatch_1 = __webpack_require__(/*! ./RenderBatch/RenderBatch */ "./Rendering/RenderBatch/RenderBatch.ts");
var EventDelegator_1 = __webpack_require__(/*! ./EventDelegator */ "./Rendering/EventDelegator.ts");
var LogicalElements_1 = __webpack_require__(/*! ./LogicalElements */ "./Rendering/LogicalElements.ts");
var ElementReferenceCapture_1 = __webpack_require__(/*! ./ElementReferenceCapture */ "./Rendering/ElementReferenceCapture.ts");
var selectValuePropname = '_blazorSelectValue';
var sharedTemplateElemForParsing = document.createElement('template');
var sharedSvgElemForParsing = document.createElementNS('http://www.w3.org/2000/svg', 'g');
var preventDefaultEvents = { submit: true };
var rootComponentsPendingFirstRender = {};
var BrowserRenderer = /** @class */ (function () {
    function BrowserRenderer(browserRendererId) {
        var _this = this;
        this.browserRendererId = browserRendererId;
        this.childComponentLocations = {};
        this.eventDelegator = new EventDelegator_1.EventDelegator(function (event, eventHandlerId, eventArgs) {
            raiseEvent(event, _this.browserRendererId, eventHandlerId, eventArgs);
        });
    }
    BrowserRenderer.prototype.attachRootComponentToElement = function (componentId, element) {
        // 'allowExistingContents' to keep any prerendered content until we do the first client-side render
        this.attachComponentToElement(componentId, LogicalElements_1.toLogicalElement(element, /* allowExistingContents */ true));
        rootComponentsPendingFirstRender[componentId] = element;
    };
    BrowserRenderer.prototype.updateComponent = function (batch, componentId, edits, referenceFrames) {
        var element = this.childComponentLocations[componentId];
        if (!element) {
            throw new Error("No element is currently associated with component " + componentId);
        }
        // On the first render for each root component, clear any existing content (e.g., prerendered)
        var rootElementToClear = rootComponentsPendingFirstRender[componentId];
        if (rootElementToClear) {
            delete rootComponentsPendingFirstRender[componentId];
            clearElement(rootElementToClear);
        }
        this.applyEdits(batch, element, 0, edits, referenceFrames);
    };
    BrowserRenderer.prototype.disposeComponent = function (componentId) {
        delete this.childComponentLocations[componentId];
    };
    BrowserRenderer.prototype.disposeEventHandler = function (eventHandlerId) {
        this.eventDelegator.removeListener(eventHandlerId);
    };
    BrowserRenderer.prototype.attachComponentToElement = function (componentId, element) {
        this.childComponentLocations[componentId] = element;
    };
    BrowserRenderer.prototype.applyEdits = function (batch, parent, childIndex, edits, referenceFrames) {
        var currentDepth = 0;
        var childIndexAtCurrentDepth = childIndex;
        var arraySegmentReader = batch.arraySegmentReader;
        var editReader = batch.editReader;
        var frameReader = batch.frameReader;
        var editsValues = arraySegmentReader.values(edits);
        var editsOffset = arraySegmentReader.offset(edits);
        var editsLength = arraySegmentReader.count(edits);
        var maxEditIndexExcl = editsOffset + editsLength;
        for (var editIndex = editsOffset; editIndex < maxEditIndexExcl; editIndex++) {
            var edit = batch.diffReader.editsEntry(editsValues, editIndex);
            var editType = editReader.editType(edit);
            switch (editType) {
                case RenderBatch_1.EditType.prependFrame: {
                    var frameIndex = editReader.newTreeIndex(edit);
                    var frame = batch.referenceFramesEntry(referenceFrames, frameIndex);
                    var siblingIndex = editReader.siblingIndex(edit);
                    this.insertFrame(batch, parent, childIndexAtCurrentDepth + siblingIndex, referenceFrames, frame, frameIndex);
                    break;
                }
                case RenderBatch_1.EditType.removeFrame: {
                    var siblingIndex = editReader.siblingIndex(edit);
                    LogicalElements_1.removeLogicalChild(parent, childIndexAtCurrentDepth + siblingIndex);
                    break;
                }
                case RenderBatch_1.EditType.setAttribute: {
                    var frameIndex = editReader.newTreeIndex(edit);
                    var frame = batch.referenceFramesEntry(referenceFrames, frameIndex);
                    var siblingIndex = editReader.siblingIndex(edit);
                    var element = LogicalElements_1.getLogicalChild(parent, childIndexAtCurrentDepth + siblingIndex);
                    if (element instanceof Element) {
                        this.applyAttribute(batch, element, frame);
                    }
                    else {
                        throw new Error("Cannot set attribute on non-element child");
                    }
                    break;
                }
                case RenderBatch_1.EditType.removeAttribute: {
                    // Note that we don't have to dispose the info we track about event handlers here, because the
                    // disposed event handler IDs are delivered separately (in the 'disposedEventHandlerIds' array)
                    var siblingIndex = editReader.siblingIndex(edit);
                    var element = LogicalElements_1.getLogicalChild(parent, childIndexAtCurrentDepth + siblingIndex);
                    if (element instanceof HTMLElement) {
                        var attributeName = editReader.removedAttributeName(edit);
                        // First try to remove any special property we use for this attribute
                        if (!this.tryApplySpecialProperty(batch, element, attributeName, null)) {
                            // If that's not applicable, it's a regular DOM attribute so remove that
                            element.removeAttribute(attributeName);
                        }
                    }
                    else {
                        throw new Error("Cannot remove attribute from non-element child");
                    }
                    break;
                }
                case RenderBatch_1.EditType.updateText: {
                    var frameIndex = editReader.newTreeIndex(edit);
                    var frame = batch.referenceFramesEntry(referenceFrames, frameIndex);
                    var siblingIndex = editReader.siblingIndex(edit);
                    var textNode = LogicalElements_1.getLogicalChild(parent, childIndexAtCurrentDepth + siblingIndex);
                    if (textNode instanceof Text) {
                        textNode.textContent = frameReader.textContent(frame);
                    }
                    else {
                        throw new Error("Cannot set text content on non-text child");
                    }
                    break;
                }
                case RenderBatch_1.EditType.updateMarkup: {
                    var frameIndex = editReader.newTreeIndex(edit);
                    var frame = batch.referenceFramesEntry(referenceFrames, frameIndex);
                    var siblingIndex = editReader.siblingIndex(edit);
                    LogicalElements_1.removeLogicalChild(parent, childIndexAtCurrentDepth + siblingIndex);
                    this.insertMarkup(batch, parent, childIndexAtCurrentDepth + siblingIndex, frame);
                    break;
                }
                case RenderBatch_1.EditType.stepIn: {
                    var siblingIndex = editReader.siblingIndex(edit);
                    parent = LogicalElements_1.getLogicalChild(parent, childIndexAtCurrentDepth + siblingIndex);
                    currentDepth++;
                    childIndexAtCurrentDepth = 0;
                    break;
                }
                case RenderBatch_1.EditType.stepOut: {
                    parent = LogicalElements_1.getLogicalParent(parent);
                    currentDepth--;
                    childIndexAtCurrentDepth = currentDepth === 0 ? childIndex : 0; // The childIndex is only ever nonzero at zero depth
                    break;
                }
                default: {
                    var unknownType = editType; // Compile-time verification that the switch was exhaustive
                    throw new Error("Unknown edit type: " + unknownType);
                }
            }
        }
    };
    BrowserRenderer.prototype.insertFrame = function (batch, parent, childIndex, frames, frame, frameIndex) {
        var frameReader = batch.frameReader;
        var frameType = frameReader.frameType(frame);
        switch (frameType) {
            case RenderBatch_1.FrameType.element:
                this.insertElement(batch, parent, childIndex, frames, frame, frameIndex);
                return 1;
            case RenderBatch_1.FrameType.text:
                this.insertText(batch, parent, childIndex, frame);
                return 1;
            case RenderBatch_1.FrameType.attribute:
                throw new Error('Attribute frames should only be present as leading children of element frames.');
            case RenderBatch_1.FrameType.component:
                this.insertComponent(batch, parent, childIndex, frame);
                return 1;
            case RenderBatch_1.FrameType.region:
                return this.insertFrameRange(batch, parent, childIndex, frames, frameIndex + 1, frameIndex + frameReader.subtreeLength(frame));
            case RenderBatch_1.FrameType.elementReferenceCapture:
                if (parent instanceof Element) {
                    ElementReferenceCapture_1.applyCaptureIdToElement(parent, frameReader.elementReferenceCaptureId(frame));
                    return 0; // A "capture" is a child in the diff, but has no node in the DOM
                }
                else {
                    throw new Error('Reference capture frames can only be children of element frames.');
                }
            case RenderBatch_1.FrameType.markup:
                this.insertMarkup(batch, parent, childIndex, frame);
                return 1;
            default:
                var unknownType = frameType; // Compile-time verification that the switch was exhaustive
                throw new Error("Unknown frame type: " + unknownType);
        }
    };
    BrowserRenderer.prototype.insertElement = function (batch, parent, childIndex, frames, frame, frameIndex) {
        var frameReader = batch.frameReader;
        var tagName = frameReader.elementName(frame);
        var newDomElementRaw = tagName === 'svg' || LogicalElements_1.isSvgElement(parent) ?
            document.createElementNS('http://www.w3.org/2000/svg', tagName) :
            document.createElement(tagName);
        var newElement = LogicalElements_1.toLogicalElement(newDomElementRaw);
        LogicalElements_1.insertLogicalChild(newDomElementRaw, parent, childIndex);
        // Apply attributes
        var descendantsEndIndexExcl = frameIndex + frameReader.subtreeLength(frame);
        for (var descendantIndex = frameIndex + 1; descendantIndex < descendantsEndIndexExcl; descendantIndex++) {
            var descendantFrame = batch.referenceFramesEntry(frames, descendantIndex);
            if (frameReader.frameType(descendantFrame) === RenderBatch_1.FrameType.attribute) {
                this.applyAttribute(batch, newDomElementRaw, descendantFrame);
            }
            else {
                // As soon as we see a non-attribute child, all the subsequent child frames are
                // not attributes, so bail out and insert the remnants recursively
                this.insertFrameRange(batch, newElement, 0, frames, descendantIndex, descendantsEndIndexExcl);
                break;
            }
        }
    };
    BrowserRenderer.prototype.insertComponent = function (batch, parent, childIndex, frame) {
        var containerElement = LogicalElements_1.createAndInsertLogicalContainer(parent, childIndex);
        // All we have to do is associate the child component ID with its location. We don't actually
        // do any rendering here, because the diff for the child will appear later in the render batch.
        var childComponentId = batch.frameReader.componentId(frame);
        this.attachComponentToElement(childComponentId, containerElement);
    };
    BrowserRenderer.prototype.insertText = function (batch, parent, childIndex, textFrame) {
        var textContent = batch.frameReader.textContent(textFrame);
        var newTextNode = document.createTextNode(textContent);
        LogicalElements_1.insertLogicalChild(newTextNode, parent, childIndex);
    };
    BrowserRenderer.prototype.insertMarkup = function (batch, parent, childIndex, markupFrame) {
        var markupContainer = LogicalElements_1.createAndInsertLogicalContainer(parent, childIndex);
        var markupContent = batch.frameReader.markupContent(markupFrame);
        var parsedMarkup = parseMarkup(markupContent, LogicalElements_1.isSvgElement(parent));
        var logicalSiblingIndex = 0;
        while (parsedMarkup.firstChild) {
            LogicalElements_1.insertLogicalChild(parsedMarkup.firstChild, markupContainer, logicalSiblingIndex++);
        }
    };
    BrowserRenderer.prototype.applyAttribute = function (batch, toDomElement, attributeFrame) {
        var frameReader = batch.frameReader;
        var attributeName = frameReader.attributeName(attributeFrame);
        var browserRendererId = this.browserRendererId;
        var eventHandlerId = frameReader.attributeEventHandlerId(attributeFrame);
        if (eventHandlerId) {
            var firstTwoChars = attributeName.substring(0, 2);
            var eventName = attributeName.substring(2);
            if (firstTwoChars !== 'on' || !eventName) {
                throw new Error("Attribute has nonzero event handler ID, but attribute name '" + attributeName + "' does not start with 'on'.");
            }
            this.eventDelegator.setListener(toDomElement, eventName, eventHandlerId);
            return;
        }
        // First see if we have special handling for this attribute
        if (!this.tryApplySpecialProperty(batch, toDomElement, attributeName, attributeFrame)) {
            // If not, treat it as a regular string-valued attribute
            toDomElement.setAttribute(attributeName, frameReader.attributeValue(attributeFrame));
        }
    };
    BrowserRenderer.prototype.tryApplySpecialProperty = function (batch, element, attributeName, attributeFrame) {
        switch (attributeName) {
            case 'value':
                return this.tryApplyValueProperty(batch, element, attributeFrame);
            case 'checked':
                return this.tryApplyCheckedProperty(batch, element, attributeFrame);
            default:
                return false;
        }
    };
    BrowserRenderer.prototype.tryApplyValueProperty = function (batch, element, attributeFrame) {
        // Certain elements have built-in behaviour for their 'value' property
        var frameReader = batch.frameReader;
        switch (element.tagName) {
            case 'INPUT':
            case 'SELECT':
            case 'TEXTAREA': {
                var value = attributeFrame ? frameReader.attributeValue(attributeFrame) : null;
                element.value = value;
                if (element.tagName === 'SELECT') {
                    // <select> is special, in that anything we write to .value will be lost if there
                    // isn't yet a matching <option>. To maintain the expected behavior no matter the
                    // element insertion/update order, preserve the desired value separately so
                    // we can recover it when inserting any matching <option>.
                    element[selectValuePropname] = value;
                }
                return true;
            }
            case 'OPTION': {
                var value = attributeFrame ? frameReader.attributeValue(attributeFrame) : null;
                if (value) {
                    element.setAttribute('value', value);
                }
                else {
                    element.removeAttribute('value');
                }
                // See above for why we have this special handling for <select>/<option>
                var parentElement = element.parentElement;
                if (parentElement && (selectValuePropname in parentElement) && parentElement[selectValuePropname] === value) {
                    this.tryApplyValueProperty(batch, parentElement, attributeFrame);
                    delete parentElement[selectValuePropname];
                }
                return true;
            }
            default:
                return false;
        }
    };
    BrowserRenderer.prototype.tryApplyCheckedProperty = function (batch, element, attributeFrame) {
        // Certain elements have built-in behaviour for their 'checked' property
        if (element.tagName === 'INPUT') {
            var value = attributeFrame ? batch.frameReader.attributeValue(attributeFrame) : null;
            element.checked = value !== null;
            return true;
        }
        else {
            return false;
        }
    };
    BrowserRenderer.prototype.insertFrameRange = function (batch, parent, childIndex, frames, startIndex, endIndexExcl) {
        var origChildIndex = childIndex;
        for (var index = startIndex; index < endIndexExcl; index++) {
            var frame = batch.referenceFramesEntry(frames, index);
            var numChildrenInserted = this.insertFrame(batch, parent, childIndex, frames, frame, index);
            childIndex += numChildrenInserted;
            // Skip over any descendants, since they are already dealt with recursively
            index += countDescendantFrames(batch, frame);
        }
        return (childIndex - origChildIndex); // Total number of children inserted
    };
    return BrowserRenderer;
}());
exports.BrowserRenderer = BrowserRenderer;
function parseMarkup(markup, isSvg) {
    if (isSvg) {
        sharedSvgElemForParsing.innerHTML = markup || ' ';
        return sharedSvgElemForParsing;
    }
    else {
        sharedTemplateElemForParsing.innerHTML = markup || ' ';
        return sharedTemplateElemForParsing.content;
    }
}
function countDescendantFrames(batch, frame) {
    var frameReader = batch.frameReader;
    switch (frameReader.frameType(frame)) {
        // The following frame types have a subtree length. Other frames may use that memory slot
        // to mean something else, so we must not read it. We should consider having nominal subtypes
        // of RenderTreeFramePointer that prevent access to non-applicable fields.
        case RenderBatch_1.FrameType.component:
        case RenderBatch_1.FrameType.element:
        case RenderBatch_1.FrameType.region:
            return frameReader.subtreeLength(frame) - 1;
        default:
            return 0;
    }
}
function raiseEvent(event, browserRendererId, eventHandlerId, eventArgs) {
    if (preventDefaultEvents[event.type]) {
        event.preventDefault();
    }
    var eventDescriptor = {
        browserRendererId: browserRendererId,
        eventHandlerId: eventHandlerId,
        eventArgsType: eventArgs.type
    };
    return DotNet.invokeMethodAsync('Microsoft.AspNetCore.Components.Browser', 'DispatchEvent', eventDescriptor, JSON.stringify(eventArgs.data));
}
function clearElement(element) {
    var childNode;
    while (childNode = element.firstChild) {
        element.removeChild(childNode);
    }
}


/***/ }),

/***/ "./Rendering/ElementReferenceCapture.ts":
/*!**********************************************!*\
  !*** ./Rendering/ElementReferenceCapture.ts ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
function applyCaptureIdToElement(element, referenceCaptureId) {
    element.setAttribute(getCaptureIdAttributeName(referenceCaptureId), '');
}
exports.applyCaptureIdToElement = applyCaptureIdToElement;
function getElementByCaptureId(referenceCaptureId) {
    var selector = "[" + getCaptureIdAttributeName(referenceCaptureId) + "]";
    return document.querySelector(selector);
}
function getCaptureIdAttributeName(referenceCaptureId) {
    return "_bl_" + referenceCaptureId;
}
// Support receiving ElementRef instances as args in interop calls
var elementRefKey = '_blazorElementRef'; // Keep in sync with ElementRef.cs
DotNet.attachReviver(function (key, value) {
    if (value && typeof value === 'object' && value.hasOwnProperty(elementRefKey) && typeof value[elementRefKey] === 'string') {
        return getElementByCaptureId(value[elementRefKey]);
    }
    else {
        return value;
    }
});


/***/ }),

/***/ "./Rendering/EventDelegator.ts":
/*!*************************************!*\
  !*** ./Rendering/EventDelegator.ts ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var EventForDotNet_1 = __webpack_require__(/*! ./EventForDotNet */ "./Rendering/EventForDotNet.ts");
var nonBubblingEvents = toLookup([
    'abort', 'blur', 'change', 'error', 'focus', 'load', 'loadend', 'loadstart', 'mouseenter', 'mouseleave',
    'progress', 'reset', 'scroll', 'submit', 'unload', 'DOMNodeInsertedIntoDocument', 'DOMNodeRemovedFromDocument'
]);
// Responsible for adding/removing the eventInfo on an expando property on DOM elements, and
// calling an EventInfoStore that deals with registering/unregistering the underlying delegated
// event listeners as required (and also maps actual events back to the given callback).
var EventDelegator = /** @class */ (function () {
    function EventDelegator(onEvent) {
        this.onEvent = onEvent;
        var eventDelegatorId = ++EventDelegator.nextEventDelegatorId;
        this.eventsCollectionKey = "_blazorEvents_" + eventDelegatorId;
        this.eventInfoStore = new EventInfoStore(this.onGlobalEvent.bind(this));
    }
    EventDelegator.prototype.setListener = function (element, eventName, eventHandlerId) {
        // Ensure we have a place to store event info for this element
        var infoForElement = element[this.eventsCollectionKey];
        if (!infoForElement) {
            infoForElement = element[this.eventsCollectionKey] = {};
        }
        if (infoForElement.hasOwnProperty(eventName)) {
            // We can cheaply update the info on the existing object and don't need any other housekeeping
            var oldInfo = infoForElement[eventName];
            this.eventInfoStore.update(oldInfo.eventHandlerId, eventHandlerId);
        }
        else {
            // Go through the whole flow which might involve registering a new global handler
            var newInfo = { element: element, eventName: eventName, eventHandlerId: eventHandlerId };
            this.eventInfoStore.add(newInfo);
            infoForElement[eventName] = newInfo;
        }
    };
    EventDelegator.prototype.removeListener = function (eventHandlerId) {
        // This method gets called whenever the .NET-side code reports that a certain event handler
        // has been disposed. However we will already have disposed the info about that handler if
        // the eventHandlerId for the (element,eventName) pair was replaced during diff application.
        var info = this.eventInfoStore.remove(eventHandlerId);
        if (info) {
            // Looks like this event handler wasn't already disposed
            // Remove the associated data from the DOM element
            var element = info.element;
            if (element.hasOwnProperty(this.eventsCollectionKey)) {
                var elementEventInfos = element[this.eventsCollectionKey];
                delete elementEventInfos[info.eventName];
                if (Object.getOwnPropertyNames(elementEventInfos).length === 0) {
                    delete element[this.eventsCollectionKey];
                }
            }
        }
    };
    EventDelegator.prototype.onGlobalEvent = function (evt) {
        if (!(evt.target instanceof Element)) {
            return;
        }
        // Scan up the element hierarchy, looking for any matching registered event handlers
        var candidateElement = evt.target;
        var eventArgs = null; // Populate lazily
        var eventIsNonBubbling = nonBubblingEvents.hasOwnProperty(evt.type);
        while (candidateElement) {
            if (candidateElement.hasOwnProperty(this.eventsCollectionKey)) {
                var handlerInfos = candidateElement[this.eventsCollectionKey];
                if (handlerInfos.hasOwnProperty(evt.type)) {
                    // We are going to raise an event for this element, so prepare info needed by the .NET code
                    if (!eventArgs) {
                        eventArgs = EventForDotNet_1.EventForDotNet.fromDOMEvent(evt);
                    }
                    var handlerInfo = handlerInfos[evt.type];
                    this.onEvent(evt, handlerInfo.eventHandlerId, eventArgs);
                }
            }
            candidateElement = eventIsNonBubbling ? null : candidateElement.parentElement;
        }
    };
    EventDelegator.nextEventDelegatorId = 0;
    return EventDelegator;
}());
exports.EventDelegator = EventDelegator;
// Responsible for adding and removing the global listener when the number of listeners
// for a given event name changes between zero and nonzero
var EventInfoStore = /** @class */ (function () {
    function EventInfoStore(globalListener) {
        this.globalListener = globalListener;
        this.infosByEventHandlerId = {};
        this.countByEventName = {};
    }
    EventInfoStore.prototype.add = function (info) {
        if (this.infosByEventHandlerId[info.eventHandlerId]) {
            // Should never happen, but we want to know if it does
            throw new Error("Event " + info.eventHandlerId + " is already tracked");
        }
        this.infosByEventHandlerId[info.eventHandlerId] = info;
        var eventName = info.eventName;
        if (this.countByEventName.hasOwnProperty(eventName)) {
            this.countByEventName[eventName]++;
        }
        else {
            this.countByEventName[eventName] = 1;
            // To make delegation work with non-bubbling events, register a 'capture' listener.
            // We preserve the non-bubbling behavior by only dispatching such events to the targeted element.
            var useCapture = nonBubblingEvents.hasOwnProperty(eventName);
            document.addEventListener(eventName, this.globalListener, useCapture);
        }
    };
    EventInfoStore.prototype.update = function (oldEventHandlerId, newEventHandlerId) {
        if (this.infosByEventHandlerId.hasOwnProperty(newEventHandlerId)) {
            // Should never happen, but we want to know if it does
            throw new Error("Event " + newEventHandlerId + " is already tracked");
        }
        // Since we're just updating the event handler ID, there's no need to update the global counts
        var info = this.infosByEventHandlerId[oldEventHandlerId];
        delete this.infosByEventHandlerId[oldEventHandlerId];
        info.eventHandlerId = newEventHandlerId;
        this.infosByEventHandlerId[newEventHandlerId] = info;
    };
    EventInfoStore.prototype.remove = function (eventHandlerId) {
        var info = this.infosByEventHandlerId[eventHandlerId];
        if (info) {
            delete this.infosByEventHandlerId[eventHandlerId];
            var eventName = info.eventName;
            if (--this.countByEventName[eventName] === 0) {
                delete this.countByEventName[eventName];
                document.removeEventListener(eventName, this.globalListener);
            }
        }
        return info;
    };
    return EventInfoStore;
}());
function toLookup(items) {
    var result = {};
    items.forEach(function (value) { result[value] = true; });
    return result;
}


/***/ }),

/***/ "./Rendering/EventForDotNet.ts":
/*!*************************************!*\
  !*** ./Rendering/EventForDotNet.ts ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __assign = (this && this.__assign) || Object.assign || function(t) {
    for (var s, i = 1, n = arguments.length; i < n; i++) {
        s = arguments[i];
        for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
            t[p] = s[p];
    }
    return t;
};
Object.defineProperty(exports, "__esModule", { value: true });
var EventForDotNet = /** @class */ (function () {
    function EventForDotNet(type, data) {
        this.type = type;
        this.data = data;
    }
    EventForDotNet.fromDOMEvent = function (event) {
        var element = event.target;
        switch (event.type) {
            case 'input':
            case 'change': {
                var targetIsCheckbox = isCheckbox(element);
                var newValue = targetIsCheckbox ? !!element['checked'] : element['value'];
                return new EventForDotNet('change', { type: event.type, value: newValue });
            }
            case 'copy':
            case 'cut':
            case 'paste':
                return new EventForDotNet('clipboard', { type: event.type });
            case 'drag':
            case 'dragend':
            case 'dragenter':
            case 'dragleave':
            case 'dragover':
            case 'dragstart':
            case 'drop':
                return new EventForDotNet('drag', parseDragEvent(event));
            case 'focus':
            case 'blur':
            case 'focusin':
            case 'focusout':
                return new EventForDotNet('focus', { type: event.type });
            case 'keydown':
            case 'keyup':
            case 'keypress':
                return new EventForDotNet('keyboard', parseKeyboardEvent(event));
            case 'contextmenu':
            case 'click':
            case 'mouseover':
            case 'mouseout':
            case 'mousemove':
            case 'mousedown':
            case 'mouseup':
            case 'dblclick':
                return new EventForDotNet('mouse', parseMouseEvent(event));
            case 'error':
                return new EventForDotNet('error', parseErrorEvent(event));
            case 'loadstart':
            case 'timeout':
            case 'abort':
            case 'load':
            case 'loadend':
            case 'progress':
                return new EventForDotNet('progress', parseProgressEvent(event));
            case 'touchcancel':
            case 'touchend':
            case 'touchmove':
            case 'touchenter':
            case 'touchleave':
            case 'touchstart':
                return new EventForDotNet('touch', parseTouchEvent(event));
            case 'gotpointercapture':
            case 'lostpointercapture':
            case 'pointercancel':
            case 'pointerdown':
            case 'pointerenter':
            case 'pointerleave':
            case 'pointermove':
            case 'pointerout':
            case 'pointerover':
            case 'pointerup':
                return new EventForDotNet('pointer', parsePointerEvent(event));
            case 'wheel':
            case 'mousewheel':
                return new EventForDotNet('wheel', parseWheelEvent(event));
            default:
                return new EventForDotNet('unknown', { type: event.type });
        }
    };
    return EventForDotNet;
}());
exports.EventForDotNet = EventForDotNet;
function parseDragEvent(event) {
    return {
        type: event.type,
        detail: event.detail,
        dataTransfer: event.dataTransfer,
        screenX: event.screenX,
        screenY: event.screenY,
        clientX: event.clientX,
        clientY: event.clientY,
        button: event.button,
        buttons: event.buttons,
        ctrlKey: event.ctrlKey,
        shiftKey: event.shiftKey,
        altKey: event.altKey,
        metaKey: event.metaKey
    };
}
function parseWheelEvent(event) {
    return __assign({}, parseMouseEvent(event), { deltaX: event.deltaX, deltaY: event.deltaY, deltaZ: event.deltaZ, deltaMode: event.deltaMode });
}
function parseErrorEvent(event) {
    return {
        type: event.type,
        message: event.message,
        filename: event.filename,
        lineno: event.lineno,
        colno: event.colno
    };
}
function parseProgressEvent(event) {
    return {
        type: event.type,
        lengthComputable: event.lengthComputable,
        loaded: event.loaded,
        total: event.total
    };
}
function parseTouchEvent(event) {
    function parseTouch(touchList) {
        var touches = [];
        for (var i = 0; i < touchList.length; i++) {
            var touch = touchList[i];
            touches.push({
                identifier: touch.identifier,
                clientX: touch.clientX,
                clientY: touch.clientY,
                screenX: touch.screenX,
                screenY: touch.screenY,
                pageX: touch.pageX,
                pageY: touch.pageY
            });
        }
        return touches;
    }
    return {
        type: event.type,
        detail: event.detail,
        touches: parseTouch(event.touches),
        targetTouches: parseTouch(event.targetTouches),
        changedTouches: parseTouch(event.changedTouches),
        ctrlKey: event.ctrlKey,
        shiftKey: event.shiftKey,
        altKey: event.altKey,
        metaKey: event.metaKey
    };
}
function parseKeyboardEvent(event) {
    return {
        type: event.type,
        key: event.key,
        code: event.code,
        location: event.location,
        repeat: event.repeat,
        ctrlKey: event.ctrlKey,
        shiftKey: event.shiftKey,
        altKey: event.altKey,
        metaKey: event.metaKey
    };
}
function parsePointerEvent(event) {
    return __assign({}, parseMouseEvent(event), { pointerId: event.pointerId, width: event.width, height: event.height, pressure: event.pressure, tiltX: event.tiltX, tiltY: event.tiltY, pointerType: event.pointerType, isPrimary: event.isPrimary });
}
function parseMouseEvent(event) {
    return {
        type: event.type,
        detail: event.detail,
        screenX: event.screenX,
        screenY: event.screenY,
        clientX: event.clientX,
        clientY: event.clientY,
        button: event.button,
        buttons: event.buttons,
        ctrlKey: event.ctrlKey,
        shiftKey: event.shiftKey,
        altKey: event.altKey,
        metaKey: event.metaKey
    };
}
function isCheckbox(element) {
    return element && element.tagName === 'INPUT' && element.getAttribute('type') === 'checkbox';
}


/***/ }),

/***/ "./Rendering/LogicalElements.ts":
/*!**************************************!*\
  !*** ./Rendering/LogicalElements.ts ***!
  \**************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

/*
  A LogicalElement plays the same role as an Element instance from the point of view of the
  API consumer. Inserting and removing logical elements updates the browser DOM just the same.

  The difference is that, unlike regular DOM mutation APIs, the LogicalElement APIs don't use
  the underlying DOM structure as the data storage for the element hierarchy. Instead, the
  LogicalElement APIs take care of tracking hierarchical relationships separately. The point
  of this is to permit a logical tree structure in which parent/child relationships don't
  have to be materialized in terms of DOM element parent/child relationships. And the reason
  why we want that is so that hierarchies of Blazor components can be tracked even when those
  components' render output need not be a single literal DOM element.

  Consumers of the API don't need to know about the implementation, but how it's done is:
  - Each LogicalElement is materialized in the DOM as either:
    - A Node instance, for actual Node instances inserted using 'insertLogicalChild' or
      for Element instances promoted to LogicalElement via 'toLogicalElement'
    - A Comment instance, for 'logical container' instances inserted using 'createAndInsertLogicalContainer'
  - Then, on that instance (i.e., the Node or Comment), we store an array of 'logical children'
    instances, e.g.,
      [firstChild, secondChild, thirdChild, ...]
    ... plus we store a reference to the 'logical parent' (if any)
  - The 'logical children' array means we can look up in O(1):
    - The number of logical children (not currently implemented because not required, but trivial)
    - The logical child at any given index
  - Whenever a logical child is added or removed, we update the parent's array of logical children
*/
Object.defineProperty(exports, "__esModule", { value: true });
var logicalChildrenPropname = createSymbolOrFallback('_blazorLogicalChildren');
var logicalParentPropname = createSymbolOrFallback('_blazorLogicalParent');
function toLogicalElement(element, allowExistingContents) {
    // Normally it's good to assert that the element has started empty, because that's the usual
    // situation and we probably have a bug if it's not. But for the element that contain prerendered
    // root components, we want to let them keep their content until we replace it.
    if (element.childNodes.length > 0 && !allowExistingContents) {
        throw new Error('New logical elements must start empty, or allowExistingContents must be true');
    }
    element[logicalChildrenPropname] = [];
    return element;
}
exports.toLogicalElement = toLogicalElement;
function createAndInsertLogicalContainer(parent, childIndex) {
    var containerElement = document.createComment('!');
    insertLogicalChild(containerElement, parent, childIndex);
    return containerElement;
}
exports.createAndInsertLogicalContainer = createAndInsertLogicalContainer;
function insertLogicalChild(child, parent, childIndex) {
    var childAsLogicalElement = child;
    if (child instanceof Comment) {
        var existingGrandchildren = getLogicalChildrenArray(childAsLogicalElement);
        if (existingGrandchildren && getLogicalChildrenArray(childAsLogicalElement).length > 0) {
            // There's nothing to stop us implementing support for this scenario, and it's not difficult
            // (after inserting 'child' itself, also iterate through its logical children and physically
            // put them as following-siblings in the DOM). However there's no scenario that requires it
            // presently, so if we did implement it there'd be no good way to have tests for it.
            throw new Error('Not implemented: inserting non-empty logical container');
        }
    }
    if (getLogicalParent(childAsLogicalElement)) {
        // Likewise, we could easily support this scenario too (in this 'if' block, just splice
        // out 'child' from the logical children array of its previous logical parent by using
        // Array.prototype.indexOf to determine its previous sibling index).
        // But again, since there's not currently any scenario that would use it, we would not
        // have any test coverage for such an implementation.
        throw new Error('Not implemented: moving existing logical children');
    }
    var newSiblings = getLogicalChildrenArray(parent);
    if (childIndex < newSiblings.length) {
        // Insert
        var nextSibling = newSiblings[childIndex];
        nextSibling.parentNode.insertBefore(child, nextSibling);
        newSiblings.splice(childIndex, 0, childAsLogicalElement);
    }
    else {
        // Append
        appendDomNode(child, parent);
        newSiblings.push(childAsLogicalElement);
    }
    childAsLogicalElement[logicalParentPropname] = parent;
    if (!(logicalChildrenPropname in childAsLogicalElement)) {
        childAsLogicalElement[logicalChildrenPropname] = [];
    }
}
exports.insertLogicalChild = insertLogicalChild;
function removeLogicalChild(parent, childIndex) {
    var childrenArray = getLogicalChildrenArray(parent);
    var childToRemove = childrenArray.splice(childIndex, 1)[0];
    // If it's a logical container, also remove its descendants
    if (childToRemove instanceof Comment) {
        var grandchildrenArray = getLogicalChildrenArray(childToRemove);
        while (grandchildrenArray.length > 0) {
            removeLogicalChild(childToRemove, 0);
        }
    }
    // Finally, remove the node itself
    var domNodeToRemove = childToRemove;
    domNodeToRemove.parentNode.removeChild(domNodeToRemove);
}
exports.removeLogicalChild = removeLogicalChild;
function getLogicalParent(element) {
    return element[logicalParentPropname] || null;
}
exports.getLogicalParent = getLogicalParent;
function getLogicalChild(parent, childIndex) {
    return getLogicalChildrenArray(parent)[childIndex];
}
exports.getLogicalChild = getLogicalChild;
function isSvgElement(element) {
    return getClosestDomElement(element).namespaceURI === 'http://www.w3.org/2000/svg';
}
exports.isSvgElement = isSvgElement;
function getLogicalChildrenArray(element) {
    return element[logicalChildrenPropname];
}
function getLogicalNextSibling(element) {
    var siblings = getLogicalChildrenArray(getLogicalParent(element));
    var siblingIndex = Array.prototype.indexOf.call(siblings, element);
    return siblings[siblingIndex + 1] || null;
}
function getClosestDomElement(logicalElement) {
    if (logicalElement instanceof Element) {
        return logicalElement;
    }
    else if (logicalElement instanceof Comment) {
        return logicalElement.parentNode;
    }
    else {
        throw new Error('Not a valid logical element');
    }
}
function appendDomNode(child, parent) {
    // This function only puts 'child' into the DOM in the right place relative to 'parent'
    // It does not update the logical children array of anything
    if (parent instanceof Element) {
        parent.appendChild(child);
    }
    else if (parent instanceof Comment) {
        var parentLogicalNextSibling = getLogicalNextSibling(parent);
        if (parentLogicalNextSibling) {
            // Since the parent has a logical next-sibling, its appended child goes right before that
            parentLogicalNextSibling.parentNode.insertBefore(child, parentLogicalNextSibling);
        }
        else {
            // Since the parent has no logical next-sibling, keep recursing upwards until we find
            // a logical ancestor that does have a next-sibling or is a physical element.
            appendDomNode(child, getLogicalParent(parent));
        }
    }
    else {
        // Should never happen
        throw new Error("Cannot append node because the parent is not a valid logical element. Parent: " + parent);
    }
}
function createSymbolOrFallback(fallback) {
    return typeof Symbol === 'function' ? Symbol() : fallback;
}
;


/***/ }),

/***/ "./Rendering/RenderBatch/RenderBatch.ts":
/*!**********************************************!*\
  !*** ./Rendering/RenderBatch/RenderBatch.ts ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var EditType;
(function (EditType) {
    // The values must be kept in sync with the .NET equivalent in RenderTreeEditType.cs
    EditType[EditType["prependFrame"] = 1] = "prependFrame";
    EditType[EditType["removeFrame"] = 2] = "removeFrame";
    EditType[EditType["setAttribute"] = 3] = "setAttribute";
    EditType[EditType["removeAttribute"] = 4] = "removeAttribute";
    EditType[EditType["updateText"] = 5] = "updateText";
    EditType[EditType["stepIn"] = 6] = "stepIn";
    EditType[EditType["stepOut"] = 7] = "stepOut";
    EditType[EditType["updateMarkup"] = 8] = "updateMarkup";
})(EditType = exports.EditType || (exports.EditType = {}));
var FrameType;
(function (FrameType) {
    // The values must be kept in sync with the .NET equivalent in RenderTreeFrameType.cs
    FrameType[FrameType["element"] = 1] = "element";
    FrameType[FrameType["text"] = 2] = "text";
    FrameType[FrameType["attribute"] = 3] = "attribute";
    FrameType[FrameType["component"] = 4] = "component";
    FrameType[FrameType["region"] = 5] = "region";
    FrameType[FrameType["elementReferenceCapture"] = 6] = "elementReferenceCapture";
    FrameType[FrameType["markup"] = 8] = "markup";
})(FrameType = exports.FrameType || (exports.FrameType = {}));


/***/ }),

/***/ "./Rendering/RenderBatch/SharedMemoryRenderBatch.ts":
/*!**********************************************************!*\
  !*** ./Rendering/RenderBatch/SharedMemoryRenderBatch.ts ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var Environment_1 = __webpack_require__(/*! ../../Environment */ "./Environment.ts");
// Used when running on Mono WebAssembly for shared-memory interop. The code here encapsulates
// our knowledge of the memory layout of RenderBatch and all referenced types.
//
// In this implementation, all the DTO types are really heap pointers at runtime, hence all
// the casts to 'any' whenever we pass them to platform.read.
var SharedMemoryRenderBatch = /** @class */ (function () {
    function SharedMemoryRenderBatch(batchAddress) {
        this.batchAddress = batchAddress;
        this.arrayRangeReader = arrayRangeReader;
        this.arraySegmentReader = arraySegmentReader;
        this.diffReader = diffReader;
        this.editReader = editReader;
        this.frameReader = frameReader;
    }
    // Keep in sync with memory layout in RenderBatch.cs
    SharedMemoryRenderBatch.prototype.updatedComponents = function () { return Environment_1.platform.readStructField(this.batchAddress, 0); };
    SharedMemoryRenderBatch.prototype.referenceFrames = function () { return Environment_1.platform.readStructField(this.batchAddress, arrayRangeReader.structLength); };
    SharedMemoryRenderBatch.prototype.disposedComponentIds = function () { return Environment_1.platform.readStructField(this.batchAddress, arrayRangeReader.structLength * 2); };
    SharedMemoryRenderBatch.prototype.disposedEventHandlerIds = function () { return Environment_1.platform.readStructField(this.batchAddress, arrayRangeReader.structLength * 3); };
    SharedMemoryRenderBatch.prototype.updatedComponentsEntry = function (values, index) {
        return arrayValuesEntry(values, index, diffReader.structLength);
    };
    SharedMemoryRenderBatch.prototype.referenceFramesEntry = function (values, index) {
        return arrayValuesEntry(values, index, frameReader.structLength);
    };
    SharedMemoryRenderBatch.prototype.disposedComponentIdsEntry = function (values, index) {
        var pointer = arrayValuesEntry(values, index, /* int length */ 4);
        return Environment_1.platform.readInt32Field(pointer);
    };
    SharedMemoryRenderBatch.prototype.disposedEventHandlerIdsEntry = function (values, index) {
        var pointer = arrayValuesEntry(values, index, /* int length */ 4);
        return Environment_1.platform.readInt32Field(pointer);
    };
    return SharedMemoryRenderBatch;
}());
exports.SharedMemoryRenderBatch = SharedMemoryRenderBatch;
// Keep in sync with memory layout in ArrayRange.cs
var arrayRangeReader = {
    structLength: 8,
    values: function (arrayRange) { return Environment_1.platform.readObjectField(arrayRange, 0); },
    count: function (arrayRange) { return Environment_1.platform.readInt32Field(arrayRange, 4); },
};
// Keep in sync with memory layout in ArraySegment
var arraySegmentReader = {
    structLength: 12,
    values: function (arraySegment) { return Environment_1.platform.readObjectField(arraySegment, 0); },
    offset: function (arraySegment) { return Environment_1.platform.readInt32Field(arraySegment, 4); },
    count: function (arraySegment) { return Environment_1.platform.readInt32Field(arraySegment, 8); },
};
// Keep in sync with memory layout in RenderTreeDiff.cs
var diffReader = {
    structLength: 4 + arraySegmentReader.structLength,
    componentId: function (diff) { return Environment_1.platform.readInt32Field(diff, 0); },
    edits: function (diff) { return Environment_1.platform.readStructField(diff, 4); },
    editsEntry: function (values, index) { return arrayValuesEntry(values, index, editReader.structLength); },
};
// Keep in sync with memory layout in RenderTreeEdit.cs
var editReader = {
    structLength: 16,
    editType: function (edit) { return Environment_1.platform.readInt32Field(edit, 0); },
    siblingIndex: function (edit) { return Environment_1.platform.readInt32Field(edit, 4); },
    newTreeIndex: function (edit) { return Environment_1.platform.readInt32Field(edit, 8); },
    removedAttributeName: function (edit) { return Environment_1.platform.readStringField(edit, 12); },
};
// Keep in sync with memory layout in RenderTreeFrame.cs
var frameReader = {
    structLength: 28,
    frameType: function (frame) { return Environment_1.platform.readInt32Field(frame, 4); },
    subtreeLength: function (frame) { return Environment_1.platform.readInt32Field(frame, 8); },
    elementReferenceCaptureId: function (frame) { return Environment_1.platform.readStringField(frame, 16); },
    componentId: function (frame) { return Environment_1.platform.readInt32Field(frame, 12); },
    elementName: function (frame) { return Environment_1.platform.readStringField(frame, 16); },
    textContent: function (frame) { return Environment_1.platform.readStringField(frame, 16); },
    markupContent: function (frame) { return Environment_1.platform.readStringField(frame, 16); },
    attributeName: function (frame) { return Environment_1.platform.readStringField(frame, 16); },
    attributeValue: function (frame) { return Environment_1.platform.readStringField(frame, 24); },
    attributeEventHandlerId: function (frame) { return Environment_1.platform.readInt32Field(frame, 8); },
};
function arrayValuesEntry(arrayValues, index, itemSize) {
    return Environment_1.platform.getArrayEntryPtr(arrayValues, index, itemSize);
}


/***/ }),

/***/ "./Rendering/Renderer.ts":
/*!*******************************!*\
  !*** ./Rendering/Renderer.ts ***!
  \*******************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var BrowserRenderer_1 = __webpack_require__(/*! ./BrowserRenderer */ "./Rendering/BrowserRenderer.ts");
var browserRenderers = {};
function attachRootComponentToElement(browserRendererId, elementSelector, componentId) {
    var element = document.querySelector(elementSelector);
    if (!element) {
        throw new Error("Could not find any element matching selector '" + elementSelector + "'.");
    }
    var browserRenderer = browserRenderers[browserRendererId];
    if (!browserRenderer) {
        browserRenderer = browserRenderers[browserRendererId] = new BrowserRenderer_1.BrowserRenderer(browserRendererId);
    }
    browserRenderer.attachRootComponentToElement(componentId, element);
}
exports.attachRootComponentToElement = attachRootComponentToElement;
function renderBatch(browserRendererId, batch) {
    var browserRenderer = browserRenderers[browserRendererId];
    if (!browserRenderer) {
        throw new Error("There is no browser renderer with ID " + browserRendererId + ".");
    }
    var arrayRangeReader = batch.arrayRangeReader;
    var updatedComponentsRange = batch.updatedComponents();
    var updatedComponentsValues = arrayRangeReader.values(updatedComponentsRange);
    var updatedComponentsLength = arrayRangeReader.count(updatedComponentsRange);
    var referenceFrames = batch.referenceFrames();
    var referenceFramesValues = arrayRangeReader.values(referenceFrames);
    var diffReader = batch.diffReader;
    for (var i = 0; i < updatedComponentsLength; i++) {
        var diff = batch.updatedComponentsEntry(updatedComponentsValues, i);
        var componentId = diffReader.componentId(diff);
        var edits = diffReader.edits(diff);
        browserRenderer.updateComponent(batch, componentId, edits, referenceFramesValues);
    }
    var disposedComponentIdsRange = batch.disposedComponentIds();
    var disposedComponentIdsValues = arrayRangeReader.values(disposedComponentIdsRange);
    var disposedComponentIdsLength = arrayRangeReader.count(disposedComponentIdsRange);
    for (var i = 0; i < disposedComponentIdsLength; i++) {
        var componentId = batch.disposedComponentIdsEntry(disposedComponentIdsValues, i);
        browserRenderer.disposeComponent(componentId);
    }
    var disposedEventHandlerIdsRange = batch.disposedEventHandlerIds();
    var disposedEventHandlerIdsValues = arrayRangeReader.values(disposedEventHandlerIdsRange);
    var disposedEventHandlerIdsLength = arrayRangeReader.count(disposedEventHandlerIdsRange);
    for (var i = 0; i < disposedEventHandlerIdsLength; i++) {
        var eventHandlerId = batch.disposedEventHandlerIdsEntry(disposedEventHandlerIdsValues, i);
        browserRenderer.disposeEventHandler(eventHandlerId);
    }
}
exports.renderBatch = renderBatch;


/***/ }),

/***/ "./Services/Http.ts":
/*!**************************!*\
  !*** ./Services/Http.ts ***!
  \**************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
Object.defineProperty(exports, "__esModule", { value: true });
var Environment_1 = __webpack_require__(/*! ../Environment */ "./Environment.ts");
var httpClientAssembly = 'Microsoft.AspNetCore.Blazor';
var httpClientNamespace = httpClientAssembly + ".Http";
var httpClientTypeName = 'WebAssemblyHttpMessageHandler';
var receiveResponseMethod;
var allocateArrayMethod;
// These are the functions we're making available for invocation from .NET
exports.internalFunctions = {
    sendAsync: sendAsync
};
function sendAsync(id, body, jsonFetchArgs) {
    return __awaiter(this, void 0, void 0, function () {
        var response, responseData, fetchOptions, requestInit, ex_1;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    fetchOptions = JSON.parse(Environment_1.platform.toJavaScriptString(jsonFetchArgs));
                    requestInit = Object.assign(fetchOptions.requestInit, fetchOptions.requestInitOverrides);
                    if (body) {
                        requestInit.body = Environment_1.platform.toUint8Array(body);
                    }
                    _a.label = 1;
                case 1:
                    _a.trys.push([1, 4, , 5]);
                    return [4 /*yield*/, fetch(fetchOptions.requestUri, requestInit)];
                case 2:
                    response = _a.sent();
                    return [4 /*yield*/, response.arrayBuffer()];
                case 3:
                    responseData = _a.sent();
                    return [3 /*break*/, 5];
                case 4:
                    ex_1 = _a.sent();
                    dispatchErrorResponse(id, ex_1.toString());
                    return [2 /*return*/];
                case 5:
                    dispatchSuccessResponse(id, response, responseData);
                    return [2 /*return*/];
            }
        });
    });
}
function dispatchSuccessResponse(id, response, responseData) {
    var responseDescriptor = {
        statusCode: response.status,
        statusText: response.statusText,
        headers: []
    };
    response.headers.forEach(function (value, name) {
        responseDescriptor.headers.push([name, value]);
    });
    if (!allocateArrayMethod) {
        allocateArrayMethod = Environment_1.platform.findMethod(httpClientAssembly, httpClientNamespace, httpClientTypeName, 'AllocateArray');
    }
    // allocate a managed byte[] of the right size
    var dotNetArray = Environment_1.platform.callMethod(allocateArrayMethod, null, [Environment_1.platform.toDotNetString(responseData.byteLength.toString())]);
    // get an Uint8Array view of it
    var array = Environment_1.platform.toUint8Array(dotNetArray);
    // copy the responseData to our managed byte[]
    array.set(new Uint8Array(responseData));
    dispatchResponse(id, Environment_1.platform.toDotNetString(JSON.stringify(responseDescriptor)), dotNetArray, 
    /* errorMessage */ null);
}
function dispatchErrorResponse(id, errorMessage) {
    dispatchResponse(id, 
    /* responseDescriptor */ null, 
    /* responseText */ null, Environment_1.platform.toDotNetString(errorMessage));
}
function dispatchResponse(id, responseDescriptor, responseData, errorMessage) {
    if (!receiveResponseMethod) {
        receiveResponseMethod = Environment_1.platform.findMethod(httpClientAssembly, httpClientNamespace, httpClientTypeName, 'ReceiveResponse');
    }
    Environment_1.platform.callMethod(receiveResponseMethod, null, [
        Environment_1.platform.toDotNetString(id.toString()),
        responseDescriptor,
        responseData,
        errorMessage,
    ]);
}


/***/ }),

/***/ "./Services/UriHelper.ts":
/*!*******************************!*\
  !*** ./Services/UriHelper.ts ***!
  \*******************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
Object.defineProperty(exports, "__esModule", { value: true });
__webpack_require__(/*! @dotnet/jsinterop */ "./node_modules/@dotnet/jsinterop/dist/Microsoft.JSInterop.js");
var hasRegisteredEventListeners = false;
// Will be initialized once someone registers
var notifyLocationChangedCallback = null;
// These are the functions we're making available for invocation from .NET
exports.internalFunctions = {
    enableNavigationInterception: enableNavigationInterception,
    navigateTo: navigateTo,
    getBaseURI: function () { return document.baseURI; },
    getLocationHref: function () { return location.href; },
};
function enableNavigationInterception(assemblyName, functionName) {
    if (hasRegisteredEventListeners || assemblyName === undefined || functionName === undefined) {
        return;
    }
    notifyLocationChangedCallback = { assemblyName: assemblyName, functionName: functionName };
    hasRegisteredEventListeners = true;
    document.addEventListener('click', function (event) {
        // Intercept clicks on all <a> elements where the href is within the <base href> URI space
        // We must explicitly check if it has an 'href' attribute, because if it doesn't, the result might be null or an empty string depending on the browser
        var anchorTarget = findClosestAncestor(event.target, 'A');
        var hrefAttributeName = 'href';
        if (anchorTarget && anchorTarget.hasAttribute(hrefAttributeName) && event.button === 0) {
            var href = anchorTarget.getAttribute(hrefAttributeName);
            var absoluteHref = toAbsoluteUri(href);
            var targetAttributeValue = anchorTarget.getAttribute('target');
            var opensInSameFrame = !targetAttributeValue || targetAttributeValue === '_self';
            // Don't stop ctrl/meta-click (etc) from opening links in new tabs/windows
            if (isWithinBaseUriSpace(absoluteHref) && !eventHasSpecialKey(event) && opensInSameFrame) {
                event.preventDefault();
                performInternalNavigation(absoluteHref);
            }
        }
    });
    window.addEventListener('popstate', handleInternalNavigation);
}
function navigateTo(uri, forceLoad) {
    var absoluteUri = toAbsoluteUri(uri);
    if (!forceLoad && isWithinBaseUriSpace(absoluteUri)) {
        performInternalNavigation(absoluteUri);
    }
    else {
        location.href = uri;
    }
}
exports.navigateTo = navigateTo;
function performInternalNavigation(absoluteInternalHref) {
    history.pushState(null, /* ignored title */ '', absoluteInternalHref);
    handleInternalNavigation();
}
function handleInternalNavigation() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    if (!notifyLocationChangedCallback) return [3 /*break*/, 2];
                    return [4 /*yield*/, DotNet.invokeMethodAsync(notifyLocationChangedCallback.assemblyName, notifyLocationChangedCallback.functionName, location.href)];
                case 1:
                    _a.sent();
                    _a.label = 2;
                case 2: return [2 /*return*/];
            }
        });
    });
}
var testAnchor;
function toAbsoluteUri(relativeUri) {
    testAnchor = testAnchor || document.createElement('a');
    testAnchor.href = relativeUri;
    return testAnchor.href;
}
function findClosestAncestor(element, tagName) {
    return !element
        ? null
        : element.tagName === tagName
            ? element
            : findClosestAncestor(element.parentElement, tagName);
}
function isWithinBaseUriSpace(href) {
    var baseUriWithTrailingSlash = toBaseUriWithTrailingSlash(document.baseURI); // TODO: Might baseURI really be null?
    return href.startsWith(baseUriWithTrailingSlash);
}
function toBaseUriWithTrailingSlash(baseUri) {
    return baseUri.substr(0, baseUri.lastIndexOf('/') + 1);
}
function eventHasSpecialKey(event) {
    return event.ctrlKey || event.shiftKey || event.altKey || event.metaKey;
}


/***/ }),

/***/ "./node_modules/@dotnet/jsinterop/dist/Microsoft.JSInterop.js":
/*!********************************************************************!*\
  !*** ./node_modules/@dotnet/jsinterop/dist/Microsoft.JSInterop.js ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// This is a single-file self-contained module to avoid the need for a Webpack build
var DotNet;
(function (DotNet) {
    window.DotNet = DotNet; // Ensure reachable from anywhere
    var jsonRevivers = [];
    var pendingAsyncCalls = {};
    var cachedJSFunctions = {};
    var nextAsyncCallId = 1; // Start at 1 because zero signals "no response needed"
    var dotNetDispatcher = null;
    /**
     * Sets the specified .NET call dispatcher as the current instance so that it will be used
     * for future invocations.
     *
     * @param dispatcher An object that can dispatch calls from JavaScript to a .NET runtime.
     */
    function attachDispatcher(dispatcher) {
        dotNetDispatcher = dispatcher;
    }
    DotNet.attachDispatcher = attachDispatcher;
    /**
     * Adds a JSON reviver callback that will be used when parsing arguments received from .NET.
     * @param reviver The reviver to add.
     */
    function attachReviver(reviver) {
        jsonRevivers.push(reviver);
    }
    DotNet.attachReviver = attachReviver;
    /**
     * Invokes the specified .NET public method synchronously. Not all hosting scenarios support
     * synchronous invocation, so if possible use invokeMethodAsync instead.
     *
     * @param assemblyName The short name (without key/version or .dll extension) of the .NET assembly containing the method.
     * @param methodIdentifier The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.
     * @param args Arguments to pass to the method, each of which must be JSON-serializable.
     * @returns The result of the operation.
     */
    function invokeMethod(assemblyName, methodIdentifier) {
        var args = [];
        for (var _i = 2; _i < arguments.length; _i++) {
            args[_i - 2] = arguments[_i];
        }
        return invokePossibleInstanceMethod(assemblyName, methodIdentifier, null, args);
    }
    DotNet.invokeMethod = invokeMethod;
    /**
     * Invokes the specified .NET public method asynchronously.
     *
     * @param assemblyName The short name (without key/version or .dll extension) of the .NET assembly containing the method.
     * @param methodIdentifier The identifier of the method to invoke. The method must have a [JSInvokable] attribute specifying this identifier.
     * @param args Arguments to pass to the method, each of which must be JSON-serializable.
     * @returns A promise representing the result of the operation.
     */
    function invokeMethodAsync(assemblyName, methodIdentifier) {
        var args = [];
        for (var _i = 2; _i < arguments.length; _i++) {
            args[_i - 2] = arguments[_i];
        }
        return invokePossibleInstanceMethodAsync(assemblyName, methodIdentifier, null, args);
    }
    DotNet.invokeMethodAsync = invokeMethodAsync;
    function invokePossibleInstanceMethod(assemblyName, methodIdentifier, dotNetObjectId, args) {
        var dispatcher = getRequiredDispatcher();
        if (dispatcher.invokeDotNetFromJS) {
            var argsJson = JSON.stringify(args, argReplacer);
            var resultJson = dispatcher.invokeDotNetFromJS(assemblyName, methodIdentifier, dotNetObjectId, argsJson);
            return resultJson ? parseJsonWithRevivers(resultJson) : null;
        }
        else {
            throw new Error('The current dispatcher does not support synchronous calls from JS to .NET. Use invokeMethodAsync instead.');
        }
    }
    function invokePossibleInstanceMethodAsync(assemblyName, methodIdentifier, dotNetObjectId, args) {
        var asyncCallId = nextAsyncCallId++;
        var resultPromise = new Promise(function (resolve, reject) {
            pendingAsyncCalls[asyncCallId] = { resolve: resolve, reject: reject };
        });
        try {
            var argsJson = JSON.stringify(args, argReplacer);
            getRequiredDispatcher().beginInvokeDotNetFromJS(asyncCallId, assemblyName, methodIdentifier, dotNetObjectId, argsJson);
        }
        catch (ex) {
            // Synchronous failure
            completePendingCall(asyncCallId, false, ex);
        }
        return resultPromise;
    }
    function getRequiredDispatcher() {
        if (dotNetDispatcher !== null) {
            return dotNetDispatcher;
        }
        throw new Error('No .NET call dispatcher has been set.');
    }
    function completePendingCall(asyncCallId, success, resultOrError) {
        if (!pendingAsyncCalls.hasOwnProperty(asyncCallId)) {
            throw new Error("There is no pending async call with ID " + asyncCallId + ".");
        }
        var asyncCall = pendingAsyncCalls[asyncCallId];
        delete pendingAsyncCalls[asyncCallId];
        if (success) {
            asyncCall.resolve(resultOrError);
        }
        else {
            asyncCall.reject(resultOrError);
        }
    }
    /**
     * Receives incoming calls from .NET and dispatches them to JavaScript.
     */
    DotNet.jsCallDispatcher = {
        /**
         * Finds the JavaScript function matching the specified identifier.
         *
         * @param identifier Identifies the globally-reachable function to be returned.
         * @returns A Function instance.
         */
        findJSFunction: findJSFunction,
        /**
         * Invokes the specified synchronous JavaScript function.
         *
         * @param identifier Identifies the globally-reachable function to invoke.
         * @param argsJson JSON representation of arguments to be passed to the function.
         * @returns JSON representation of the invocation result.
         */
        invokeJSFromDotNet: function (identifier, argsJson) {
            var result = findJSFunction(identifier).apply(null, parseJsonWithRevivers(argsJson));
            return result === null || result === undefined
                ? null
                : JSON.stringify(result, argReplacer);
        },
        /**
         * Invokes the specified synchronous or asynchronous JavaScript function.
         *
         * @param asyncHandle A value identifying the asynchronous operation. This value will be passed back in a later call to endInvokeJSFromDotNet.
         * @param identifier Identifies the globally-reachable function to invoke.
         * @param argsJson JSON representation of arguments to be passed to the function.
         */
        beginInvokeJSFromDotNet: function (asyncHandle, identifier, argsJson) {
            // Coerce synchronous functions into async ones, plus treat
            // synchronous exceptions the same as async ones
            var promise = new Promise(function (resolve) {
                var synchronousResultOrPromise = findJSFunction(identifier).apply(null, parseJsonWithRevivers(argsJson));
                resolve(synchronousResultOrPromise);
            });
            // We only listen for a result if the caller wants to be notified about it
            if (asyncHandle) {
                // On completion, dispatch result back to .NET
                // Not using "await" because it codegens a lot of boilerplate
                promise.then(function (result) { return getRequiredDispatcher().beginInvokeDotNetFromJS(0, 'Microsoft.JSInterop', 'DotNetDispatcher.EndInvoke', null, JSON.stringify([asyncHandle, true, result], argReplacer)); }, function (error) { return getRequiredDispatcher().beginInvokeDotNetFromJS(0, 'Microsoft.JSInterop', 'DotNetDispatcher.EndInvoke', null, JSON.stringify([asyncHandle, false, formatError(error)])); });
            }
        },
        /**
         * Receives notification that an async call from JS to .NET has completed.
         * @param asyncCallId The identifier supplied in an earlier call to beginInvokeDotNetFromJS.
         * @param success A flag to indicate whether the operation completed successfully.
         * @param resultOrExceptionMessage Either the operation result or an error message.
         */
        endInvokeDotNetFromJS: function (asyncCallId, success, resultOrExceptionMessage) {
            var resultOrError = success ? resultOrExceptionMessage : new Error(resultOrExceptionMessage);
            completePendingCall(parseInt(asyncCallId), success, resultOrError);
        }
    };
    function parseJsonWithRevivers(json) {
        return json ? JSON.parse(json, function (key, initialValue) {
            // Invoke each reviver in order, passing the output from the previous reviver,
            // so that each one gets a chance to transform the value
            return jsonRevivers.reduce(function (latestValue, reviver) { return reviver(key, latestValue); }, initialValue);
        }) : null;
    }
    function formatError(error) {
        if (error instanceof Error) {
            return error.message + "\n" + error.stack;
        }
        else {
            return error ? error.toString() : 'null';
        }
    }
    function findJSFunction(identifier) {
        if (cachedJSFunctions.hasOwnProperty(identifier)) {
            return cachedJSFunctions[identifier];
        }
        var result = window;
        var resultIdentifier = 'window';
        identifier.split('.').forEach(function (segment) {
            if (segment in result) {
                result = result[segment];
                resultIdentifier += '.' + segment;
            }
            else {
                throw new Error("Could not find '" + segment + "' in '" + resultIdentifier + "'.");
            }
        });
        if (result instanceof Function) {
            return result;
        }
        else {
            throw new Error("The value '" + resultIdentifier + "' is not a function.");
        }
    }
    var DotNetObject = /** @class */ (function () {
        function DotNetObject(_id) {
            this._id = _id;
        }
        DotNetObject.prototype.invokeMethod = function (methodIdentifier) {
            var args = [];
            for (var _i = 1; _i < arguments.length; _i++) {
                args[_i - 1] = arguments[_i];
            }
            return invokePossibleInstanceMethod(null, methodIdentifier, this._id, args);
        };
        DotNetObject.prototype.invokeMethodAsync = function (methodIdentifier) {
            var args = [];
            for (var _i = 1; _i < arguments.length; _i++) {
                args[_i - 1] = arguments[_i];
            }
            return invokePossibleInstanceMethodAsync(null, methodIdentifier, this._id, args);
        };
        DotNetObject.prototype.dispose = function () {
            var promise = invokeMethodAsync('Microsoft.JSInterop', 'DotNetDispatcher.ReleaseDotNetObject', this._id);
            promise.catch(function (error) { return console.error(error); });
        };
        DotNetObject.prototype.serializeAsArg = function () {
            return "__dotNetObject:" + this._id;
        };
        return DotNetObject;
    }());
    var dotNetObjectValueFormat = /^__dotNetObject\:(\d+)$/;
    attachReviver(function reviveDotNetObject(key, value) {
        if (typeof value === 'string') {
            var match = value.match(dotNetObjectValueFormat);
            if (match) {
                return new DotNetObject(parseInt(match[1]));
            }
        }
        // Unrecognized - let another reviver handle it
        return value;
    });
    function argReplacer(key, value) {
        return value instanceof DotNetObject ? value.serializeAsArg() : value;
    }
})(DotNet || (DotNet = {}));
//# sourceMappingURL=Microsoft.JSInterop.js.map

/***/ })

/******/ });
//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vd2VicGFjay9ib290c3RyYXAiLCJ3ZWJwYWNrOi8vLy4vQm9vdC5XZWJBc3NlbWJseS50cyIsIndlYnBhY2s6Ly8vLi9Cb290Q29tbW9uLnRzIiwid2VicGFjazovLy8uL0Vudmlyb25tZW50LnRzIiwid2VicGFjazovLy8uL0dsb2JhbEV4cG9ydHMudHMiLCJ3ZWJwYWNrOi8vLy4vUGxhdGZvcm0vTW9uby9Nb25vRGVidWdnZXIudHMiLCJ3ZWJwYWNrOi8vLy4vUGxhdGZvcm0vTW9uby9Nb25vUGxhdGZvcm0udHMiLCJ3ZWJwYWNrOi8vLy4vUGxhdGZvcm0vVXJsLnRzIiwid2VicGFjazovLy8uL1JlbmRlcmluZy9Ccm93c2VyUmVuZGVyZXIudHMiLCJ3ZWJwYWNrOi8vLy4vUmVuZGVyaW5nL0VsZW1lbnRSZWZlcmVuY2VDYXB0dXJlLnRzIiwid2VicGFjazovLy8uL1JlbmRlcmluZy9FdmVudERlbGVnYXRvci50cyIsIndlYnBhY2s6Ly8vLi9SZW5kZXJpbmcvRXZlbnRGb3JEb3ROZXQudHMiLCJ3ZWJwYWNrOi8vLy4vUmVuZGVyaW5nL0xvZ2ljYWxFbGVtZW50cy50cyIsIndlYnBhY2s6Ly8vLi9SZW5kZXJpbmcvUmVuZGVyQmF0Y2gvUmVuZGVyQmF0Y2gudHMiLCJ3ZWJwYWNrOi8vLy4vUmVuZGVyaW5nL1JlbmRlckJhdGNoL1NoYXJlZE1lbW9yeVJlbmRlckJhdGNoLnRzIiwid2VicGFjazovLy8uL1JlbmRlcmluZy9SZW5kZXJlci50cyIsIndlYnBhY2s6Ly8vLi9TZXJ2aWNlcy9IdHRwLnRzIiwid2VicGFjazovLy8uL1NlcnZpY2VzL1VyaUhlbHBlci50cyIsIndlYnBhY2s6Ly8vLi9ub2RlX21vZHVsZXMvQGRvdG5ldC9qc2ludGVyb3AvZGlzdC9NaWNyb3NvZnQuSlNJbnRlcm9wLmpzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiI7QUFBQTtBQUNBOztBQUVBO0FBQ0E7O0FBRUE7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNB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RUQsNEJBQTRCLEtBQWlCO0lBQzNDLE9BQU8sS0FBSyxDQUFDLE9BQU8sSUFBSSxLQUFLLENBQUMsUUFBUSxJQUFJLEtBQUssQ0FBQyxNQUFNLElBQUksS0FBSyxDQUFDLE9BQU8sQ0FBQztBQUMxRSxDQUFDOzs7Ozs7Ozs7Ozs7O0FDaEdEO0FBQ0E7QUFDQTtBQUNBO0FBQ0EsMkJBQTJCO0FBQzNCO0FBQ0E7QUFDQTtBQUNBLDRCQUE0QjtBQUM1QjtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSx3QkFBd0IsdUJBQXVCO0FBQy9DO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBLHdCQUF3Qix1QkFBdUI7QUFDL0M7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSw4Q0FBOEM7QUFDOUMsU0FBUztBQUNUO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0EsU0FBUztBQUNUO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0EsYUFBYTtBQUNiO0FBQ0E7QUFDQTtBQUNBO0FBQ0EsZ0RBQWdELGdMQUFnTCxFQUFFLG9CQUFvQixnTEFBZ0wsRUFBRTtBQUN4YTtBQUNBLFNBQVM7QUFDVDtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSx3RUFBd0Usa0NBQWtDLEVBQUU7QUFDNUcsU0FBUztBQUNUO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSxTQUFTO0FBQ1Q7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSw0QkFBNEIsdUJBQXVCO0FBQ25EO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBLDRCQUE0Qix1QkFBdUI7QUFDbkQ7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0EsNENBQTRDLDZCQUE2QixFQUFFO0FBQzNFO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSxLQUFLO0FBQ0w7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQSxLQUFLO0FBQ0w7QUFDQTtBQUNBO0FBQ0EsQ0FBQyx3QkFBd0I7QUFDekIsK0MiLCJmaWxlIjoiY29tcG9uZW50cy53ZWJhc3NlbWJseS5qcyIsInNvdXJjZXNDb250ZW50IjpbIiBcdC8vIFRoZSBtb2R1bGUgY2FjaGVcbiBcdHZhciBpbnN0YWxsZWRNb2R1bGVzID0ge307XG5cbiBcdC8vIFRoZSByZXF1aXJlIGZ1bmN0aW9uXG4gXHRmdW5jdGlvbiBfX3dlYnBhY2tfcmVxdWlyZV9fKG1vZHVsZUlkKSB7XG5cbiBcdFx0Ly8gQ2hlY2sgaWYgbW9kdWxlIGlzIGluIGNhY2hlXG4gXHRcdGlmKGluc3RhbGxlZE1vZHVsZXNbbW9kdWxlSWRdKSB7XG4gXHRcdFx0cmV0dXJuIGluc3RhbGxlZE1vZHVsZXNbbW9kdWxlSWRdLmV4cG9ydHM7XG4gXHRcdH1cbiBcdFx0Ly8gQ3JlYXRlIGEgbmV3IG1vZHVsZSAoYW5kIHB1dCBpdCBpbnRvIHRoZSBjYWNoZSlcbiBcdFx0dmFyIG1vZHVsZSA9IGluc3RhbGxlZE1vZHVsZXNbbW9kdWxlSWRdID0ge1xuIFx0XHRcdGk6IG1vZHVsZUlkLFxuIFx0XHRcdGw6IGZhbHNlLFxuIFx0XHRcdGV4cG9ydHM6IHt9XG4gXHRcdH07XG5cbiBcdFx0Ly8gRXhlY3V0ZSB0aGUgbW9kdWxlIGZ1bmN0aW9uXG4gXHRcdG1vZHVsZXNbbW9kdWxlSWRdLmNhbGwobW9kdWxlLmV4cG9ydHMsIG1vZHVsZSwgbW9kdWxlLmV4cG9ydHMsIF9fd2VicGFja19yZXF1aXJlX18pO1xuXG4gXHRcdC8vIEZsYWcgdGhlIG1vZHVsZSBhcyBsb2FkZWRcbiBcdFx0bW9kdWxlLmwgPSB0cnVlO1xuXG4gXHRcdC8vIFJldHVybiB0aGUgZXhwb3J0cyBvZiB0aGUgbW9kdWxlXG4gXHRcdHJldHVybiBtb2R1bGUuZXhwb3J0cztcbiBcdH1cblxuXG4gXHQvLyBleHBvc2UgdGhlIG1vZHVsZXMgb2JqZWN0IChfX3dlYnBhY2tfbW9kdWxlc19fKVxuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5tID0gbW9kdWxlcztcblxuIFx0Ly8gZXhwb3NlIHRoZSBtb2R1bGUgY2FjaGVcbiBcdF9fd2VicGFja19yZXF1aXJlX18uYyA9IGluc3RhbGxlZE1vZHVsZXM7XG5cbiBcdC8vIGRlZmluZSBnZXR0ZXIgZnVuY3Rpb24gZm9yIGhhcm1vbnkgZXhwb3J0c1xuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5kID0gZnVuY3Rpb24oZXhwb3J0cywgbmFtZSwgZ2V0dGVyKSB7XG4gXHRcdGlmKCFfX3dlYnBhY2tfcmVxdWlyZV9fLm8oZXhwb3J0cywgbmFtZSkpIHtcbiBcdFx0XHRPYmplY3QuZGVmaW5lUHJvcGVydHkoZXhwb3J0cywgbmFtZSwgeyBlbnVtZXJhYmxlOiB0cnVlLCBnZXQ6IGdldHRlciB9KTtcbiBcdFx0fVxuIFx0fTtcblxuIFx0Ly8gZGVmaW5lIF9fZXNNb2R1bGUgb24gZXhwb3J0c1xuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5yID0gZnVuY3Rpb24oZXhwb3J0cykge1xuIFx0XHRpZih0eXBlb2YgU3ltYm9sICE9PSAndW5kZWZpbmVkJyAmJiBTeW1ib2wudG9TdHJpbmdUYWcpIHtcbiBcdFx0XHRPYmplY3QuZGVmaW5lUHJvcGVydHkoZXhwb3J0cywgU3ltYm9sLnRvU3RyaW5nVGFnLCB7IHZhbHVlOiAnTW9kdWxlJyB9KTtcbiBcdFx0fVxuIFx0XHRPYmplY3QuZGVmaW5lUHJvcGVydHkoZXhwb3J0cywgJ19fZXNNb2R1bGUnLCB7IHZhbHVlOiB0cnVlIH0pO1xuIFx0fTtcblxuIFx0Ly8gY3JlYXRlIGEgZmFrZSBuYW1lc3BhY2Ugb2JqZWN0XG4gXHQvLyBtb2RlICYgMTogdmFsdWUgaXMgYSBtb2R1bGUgaWQsIHJlcXVpcmUgaXRcbiBcdC8vIG1vZGUgJiAyOiBtZXJnZSBhbGwgcHJvcGVydGllcyBvZiB2YWx1ZSBpbnRvIHRoZSBuc1xuIFx0Ly8gbW9kZSAmIDQ6IHJldHVybiB2YWx1ZSB3aGVuIGFscmVhZHkgbnMgb2JqZWN0XG4gXHQvLyBtb2RlICYgOHwxOiBiZWhhdmUgbGlrZSByZXF1aXJlXG4gXHRfX3dlYnBhY2tfcmVxdWlyZV9fLnQgPSBmdW5jdGlvbih2YWx1ZSwgbW9kZSkge1xuIFx0XHRpZihtb2RlICYgMSkgdmFsdWUgPSBfX3dlYnBhY2tfcmVxdWlyZV9fKHZhbHVlKTtcbiBcdFx0aWYobW9kZSAmIDgpIHJldHVybiB2YWx1ZTtcbiBcdFx0aWYoKG1vZGUgJiA0KSAmJiB0eXBlb2YgdmFsdWUgPT09ICdvYmplY3QnICYmIHZhbHVlICYmIHZhbHVlLl9fZXNNb2R1bGUpIHJldHVybiB2YWx1ZTtcbiBcdFx0dmFyIG5zID0gT2JqZWN0LmNyZWF0ZShudWxsKTtcbiBcdFx0X193ZWJwYWNrX3JlcXVpcmVfXy5yKG5zKTtcbiBcdFx0T2JqZWN0LmRlZmluZVByb3BlcnR5KG5zLCAnZGVmYXVsdCcsIHsgZW51bWVyYWJsZTogdHJ1ZSwgdmFsdWU6IHZhbHVlIH0pO1xuIFx0XHRpZihtb2RlICYgMiAmJiB0eXBlb2YgdmFsdWUgIT0gJ3N0cmluZycpIGZvcih2YXIga2V5IGluIHZhbHVlKSBfX3dlYnBhY2tfcmVxdWlyZV9fLmQobnMsIGtleSwgZnVuY3Rpb24oa2V5KSB7IHJldHVybiB2YWx1ZVtrZXldOyB9LmJpbmQobnVsbCwga2V5KSk7XG4gXHRcdHJldHVybiBucztcbiBcdH07XG5cbiBcdC8vIGdldERlZmF1bHRFeHBvcnQgZnVuY3Rpb24gZm9yIGNvbXBhdGliaWxpdHkgd2l0aCBub24taGFybW9ueSBtb2R1bGVzXG4gXHRfX3dlYnBhY2tfcmVxdWlyZV9fLm4gPSBmdW5jdGlvbihtb2R1bGUpIHtcbiBcdFx0dmFyIGdldHRlciA9IG1vZHVsZSAmJiBtb2R1bGUuX19lc01vZHVsZSA/XG4gXHRcdFx0ZnVuY3Rpb24gZ2V0RGVmYXVsdCgpIHsgcmV0dXJuIG1vZHVsZVsnZGVmYXVsdCddOyB9IDpcbiBcdFx0XHRmdW5jdGlvbiBnZXRNb2R1bGVFeHBvcnRzKCkgeyByZXR1cm4gbW9kdWxlOyB9O1xuIFx0XHRfX3dlYnBhY2tfcmVxdWlyZV9fLmQoZ2V0dGVyLCAnYScsIGdldHRlcik7XG4gXHRcdHJldHVybiBnZXR0ZXI7XG4gXHR9O1xuXG4gXHQvLyBPYmplY3QucHJvdG90eXBlLmhhc093blByb3BlcnR5LmNhbGxcbiBcdF9fd2VicGFja19yZXF1aXJlX18ubyA9IGZ1bmN0aW9uKG9iamVjdCwgcHJvcGVydHkpIHsgcmV0dXJuIE9iamVjdC5wcm90b3R5cGUuaGFzT3duUHJvcGVydHkuY2FsbChvYmplY3QsIHByb3BlcnR5KTsgfTtcblxuIFx0Ly8gX193ZWJwYWNrX3B1YmxpY19wYXRoX19cbiBcdF9fd2VicGFja19yZXF1aXJlX18ucCA9IFwiXCI7XG5cblxuIFx0Ly8gTG9hZCBlbnRyeSBtb2R1bGUgYW5kIHJldHVybiBleHBvcnRzXG4gXHRyZXR1cm4gX193ZWJwYWNrX3JlcXVpcmVfXyhfX3dlYnBhY2tfcmVxdWlyZV9fLnMgPSBcIi4vQm9vdC5XZWJBc3NlbWJseS50c1wiKTtcbiIsImltcG9ydCAnQGRvdG5ldC9qc2ludGVyb3AnO1xuaW1wb3J0ICcuL0dsb2JhbEV4cG9ydHMnO1xuaW1wb3J0ICogYXMgRW52aXJvbm1lbnQgZnJvbSAnLi9FbnZpcm9ubWVudCc7XG5pbXBvcnQgeyBtb25vUGxhdGZvcm0gfSBmcm9tICcuL1BsYXRmb3JtL01vbm8vTW9ub1BsYXRmb3JtJztcbmltcG9ydCB7IGdldEFzc2VtYmx5TmFtZUZyb21VcmwgfSBmcm9tICcuL1BsYXRmb3JtL1VybCc7XG5pbXBvcnQgeyByZW5kZXJCYXRjaCB9IGZyb20gJy4vUmVuZGVyaW5nL1JlbmRlcmVyJztcbmltcG9ydCB7IFNoYXJlZE1lbW9yeVJlbmRlckJhdGNoIH0gZnJvbSAnLi9SZW5kZXJpbmcvUmVuZGVyQmF0Y2gvU2hhcmVkTWVtb3J5UmVuZGVyQmF0Y2gnO1xuaW1wb3J0IHsgUG9pbnRlciB9IGZyb20gJy4vUGxhdGZvcm0vUGxhdGZvcm0nO1xuaW1wb3J0IHsgZmV0Y2hCb290Q29uZmlnQXN5bmMsIGxvYWRFbWJlZGRlZFJlc291cmNlc0FzeW5jIH0gZnJvbSAnLi9Cb290Q29tbW9uJztcblxuYXN5bmMgZnVuY3Rpb24gYm9vdCgpIHtcbiAgLy8gQ29uZmlndXJlIGVudmlyb25tZW50IGZvciBleGVjdXRpb24gdW5kZXIgTW9ubyBXZWJBc3NlbWJseSB3aXRoIHNoYXJlZC1tZW1vcnkgcmVuZGVyaW5nXG4gIGNvbnN0IHBsYXRmb3JtID0gRW52aXJvbm1lbnQuc2V0UGxhdGZvcm0obW9ub1BsYXRmb3JtKTtcbiAgd2luZG93WydCbGF6b3InXS5wbGF0Zm9ybSA9IHBsYXRmb3JtO1xuICB3aW5kb3dbJ0JsYXpvciddLl9pbnRlcm5hbC5yZW5kZXJCYXRjaCA9IChicm93c2VyUmVuZGVyZXJJZDogbnVtYmVyLCBiYXRjaEFkZHJlc3M6IFBvaW50ZXIpID0+IHtcbiAgICByZW5kZXJCYXRjaChicm93c2VyUmVuZGVyZXJJZCwgbmV3IFNoYXJlZE1lbW9yeVJlbmRlckJhdGNoKGJhdGNoQWRkcmVzcykpO1xuICB9O1xuXG4gIC8vIEZldGNoIHRoZSBib290IEpTT04gZmlsZVxuICBjb25zdCBib290Q29uZmlnID0gYXdhaXQgZmV0Y2hCb290Q29uZmlnQXN5bmMoKTtcbiAgY29uc3QgZW1iZWRkZWRSZXNvdXJjZXNQcm9taXNlID0gbG9hZEVtYmVkZGVkUmVzb3VyY2VzQXN5bmMoYm9vdENvbmZpZyk7XG5cbiAgaWYgKCFib290Q29uZmlnLmxpbmtlckVuYWJsZWQpIHtcbiAgICBjb25zb2xlLmluZm8oJ0JsYXpvciBpcyBydW5uaW5nIGluIGRldiBtb2RlIHdpdGhvdXQgSUwgc3RyaXBwaW5nLiBUbyBtYWtlIHRoZSBidW5kbGUgc2l6ZSBzaWduaWZpY2FudGx5IHNtYWxsZXIsIHB1Ymxpc2ggdGhlIGFwcGxpY2F0aW9uIG9yIHNlZSBodHRwczovL2dvLm1pY3Jvc29mdC5jb20vZndsaW5rLz9saW5raWQ9ODcwNDE0Jyk7XG4gIH1cblxuICAvLyBEZXRlcm1pbmUgdGhlIFVSTHMgb2YgdGhlIGFzc2VtYmxpZXMgd2Ugd2FudCB0byBsb2FkLCB0aGVuIGJlZ2luIGZldGNoaW5nIHRoZW0gYWxsXG4gIGNvbnN0IGxvYWRBc3NlbWJseVVybHMgPSBbYm9vdENvbmZpZy5tYWluXVxuICAgIC5jb25jYXQoYm9vdENvbmZpZy5hc3NlbWJseVJlZmVyZW5jZXMpXG4gICAgLm1hcChmaWxlbmFtZSA9PiBgX2ZyYW1ld29yay9fYmluLyR7ZmlsZW5hbWV9YCk7XG5cbiAgdHJ5IHtcbiAgICBhd2FpdCBwbGF0Zm9ybS5zdGFydChsb2FkQXNzZW1ibHlVcmxzKTtcbiAgfSBjYXRjaCAoZXgpIHtcbiAgICB0aHJvdyBuZXcgRXJyb3IoYEZhaWxlZCB0byBzdGFydCBwbGF0Zm9ybS4gUmVhc29uOiAke2V4fWApO1xuICB9XG5cbiAgLy8gQmVmb3JlIHdlIHN0YXJ0IHJ1bm5pbmcgLk5FVCBjb2RlLCBiZSBzdXJlIGVtYmVkZGVkIGNvbnRlbnQgcmVzb3VyY2VzIGFyZSBhbGwgbG9hZGVkXG4gIGF3YWl0IGVtYmVkZGVkUmVzb3VyY2VzUHJvbWlzZTtcblxuICAvLyBTdGFydCB1cCB0aGUgYXBwbGljYXRpb25cbiAgY29uc3QgbWFpbkFzc2VtYmx5TmFtZSA9IGdldEFzc2VtYmx5TmFtZUZyb21VcmwoYm9vdENvbmZpZy5tYWluKTtcbiAgcGxhdGZvcm0uY2FsbEVudHJ5UG9pbnQobWFpbkFzc2VtYmx5TmFtZSwgYm9vdENvbmZpZy5lbnRyeVBvaW50LCBbXSk7XG59XG5cbmJvb3QoKTtcbiIsImV4cG9ydCBhc3luYyBmdW5jdGlvbiBmZXRjaEJvb3RDb25maWdBc3luYygpIHtcbiAgLy8gTGF0ZXIgd2UgbWlnaHQgbWFrZSB0aGUgbG9jYXRpb24gb2YgdGhpcyBjb25maWd1cmFibGUgKGUuZy4sIGFzIGFuIGF0dHJpYnV0ZSBvbiB0aGUgPHNjcmlwdD5cbiAgLy8gZWxlbWVudCB0aGF0J3MgaW1wb3J0aW5nIHRoaXMgZmlsZSksIGJ1dCBjdXJyZW50bHkgdGhlcmUgaXNuJ3QgYSB1c2UgY2FzZSBmb3IgdGhhdC5cbiAgY29uc3QgYm9vdENvbmZpZ1Jlc3BvbnNlID0gYXdhaXQgZmV0Y2goJ19mcmFtZXdvcmsvYmxhem9yLmJvb3QuanNvbicsIHsgbWV0aG9kOiAnR2V0JywgY3JlZGVudGlhbHM6ICdpbmNsdWRlJyB9KTtcbiAgcmV0dXJuIGJvb3RDb25maWdSZXNwb25zZS5qc29uKCkgYXMgUHJvbWlzZTxCb290SnNvbkRhdGE+O1xufVxuXG5leHBvcnQgZnVuY3Rpb24gbG9hZEVtYmVkZGVkUmVzb3VyY2VzQXN5bmMoYm9vdENvbmZpZzogQm9vdEpzb25EYXRhKTogUHJvbWlzZTxhbnk+IHtcbiAgY29uc3QgY3NzTG9hZGluZ1Byb21pc2VzID0gYm9vdENvbmZpZy5jc3NSZWZlcmVuY2VzLm1hcChjc3NSZWZlcmVuY2UgPT4ge1xuICAgIGNvbnN0IGxpbmtFbGVtZW50ID0gZG9jdW1lbnQuY3JlYXRlRWxlbWVudCgnbGluaycpO1xuICAgIGxpbmtFbGVtZW50LnJlbCA9ICdzdHlsZXNoZWV0JztcbiAgICBsaW5rRWxlbWVudC5ocmVmID0gY3NzUmVmZXJlbmNlO1xuICAgIHJldHVybiBsb2FkUmVzb3VyY2VGcm9tRWxlbWVudChsaW5rRWxlbWVudCk7XG4gIH0pO1xuICBjb25zdCBqc0xvYWRpbmdQcm9taXNlcyA9IGJvb3RDb25maWcuanNSZWZlcmVuY2VzLm1hcChqc1JlZmVyZW5jZSA9PiB7XG4gICAgY29uc3Qgc2NyaXB0RWxlbWVudCA9IGRvY3VtZW50LmNyZWF0ZUVsZW1lbnQoJ3NjcmlwdCcpO1xuICAgIHNjcmlwdEVsZW1lbnQuc3JjID0ganNSZWZlcmVuY2U7XG4gICAgcmV0dXJuIGxvYWRSZXNvdXJjZUZyb21FbGVtZW50KHNjcmlwdEVsZW1lbnQpO1xuICB9KTtcbiAgcmV0dXJuIFByb21pc2UuYWxsKGNzc0xvYWRpbmdQcm9taXNlcy5jb25jYXQoanNMb2FkaW5nUHJvbWlzZXMpKTtcbn1cblxuZnVuY3Rpb24gbG9hZFJlc291cmNlRnJvbUVsZW1lbnQoZWxlbWVudDogSFRNTEVsZW1lbnQpIHtcbiAgcmV0dXJuIG5ldyBQcm9taXNlKChyZXNvbHZlLCByZWplY3QpID0+IHtcbiAgICBlbGVtZW50Lm9ubG9hZCA9IHJlc29sdmU7XG4gICAgZWxlbWVudC5vbmVycm9yID0gcmVqZWN0O1xuICAgIGRvY3VtZW50LmhlYWQhLmFwcGVuZENoaWxkKGVsZW1lbnQpO1xuICB9KTtcbn1cblxuLy8gS2VlcCBpbiBzeW5jIHdpdGggQm9vdEpzb25EYXRhIGluIE1pY3Jvc29mdC5Bc3BOZXRDb3JlLkJsYXpvci5CdWlsZFxuaW50ZXJmYWNlIEJvb3RKc29uRGF0YSB7XG4gIG1haW46IHN0cmluZztcbiAgZW50cnlQb2ludDogc3RyaW5nO1xuICBhc3NlbWJseVJlZmVyZW5jZXM6IHN0cmluZ1tdO1xuICBjc3NSZWZlcmVuY2VzOiBzdHJpbmdbXTtcbiAganNSZWZlcmVuY2VzOiBzdHJpbmdbXTtcbiAgbGlua2VyRW5hYmxlZDogYm9vbGVhbjtcbn1cbiIsIi8vIEV4cG9zZSBhbiBleHBvcnQgY2FsbGVkICdwbGF0Zm9ybScgb2YgdGhlIGludGVyZmFjZSB0eXBlICdQbGF0Zm9ybScsXG4vLyBzbyB0aGF0IGNvbnN1bWVycyBjYW4gYmUgYWdub3N0aWMgYWJvdXQgd2hpY2ggaW1wbGVtZW50YXRpb24gdGhleSB1c2UuXG4vLyBCYXNpYyBhbHRlcm5hdGl2ZSB0byBoYXZpbmcgYW4gYWN0dWFsIERJIGNvbnRhaW5lci5cbmltcG9ydCB7IFBsYXRmb3JtIH0gZnJvbSAnLi9QbGF0Zm9ybS9QbGF0Zm9ybSc7XG5cbmV4cG9ydCBsZXQgcGxhdGZvcm06IFBsYXRmb3JtO1xuXG5leHBvcnQgZnVuY3Rpb24gc2V0UGxhdGZvcm0ocGxhdGZvcm1JbnN0YW5jZTogUGxhdGZvcm0pIHtcbiAgcGxhdGZvcm0gPSBwbGF0Zm9ybUluc3RhbmNlO1xuICByZXR1cm4gcGxhdGZvcm07XG59XG4iLCJpbXBvcnQgeyBwbGF0Zm9ybSB9IGZyb20gJy4vRW52aXJvbm1lbnQnO1xuaW1wb3J0IHsgbmF2aWdhdGVUbywgaW50ZXJuYWxGdW5jdGlvbnMgYXMgdXJpSGVscGVySW50ZXJuYWxGdW5jdGlvbnMgfSBmcm9tICcuL1NlcnZpY2VzL1VyaUhlbHBlcic7XG5pbXBvcnQgeyBpbnRlcm5hbEZ1bmN0aW9ucyBhcyBodHRwSW50ZXJuYWxGdW5jdGlvbnMgfSBmcm9tICcuL1NlcnZpY2VzL0h0dHAnO1xuaW1wb3J0IHsgYXR0YWNoUm9vdENvbXBvbmVudFRvRWxlbWVudCB9IGZyb20gJy4vUmVuZGVyaW5nL1JlbmRlcmVyJztcbmltcG9ydCB7IFBvaW50ZXIgfSBmcm9tICcuL1BsYXRmb3JtL1BsYXRmb3JtJztcblxuLy8gTWFrZSB0aGUgZm9sbG93aW5nIEFQSXMgYXZhaWxhYmxlIGluIGdsb2JhbCBzY29wZSBmb3IgaW52b2NhdGlvbiBmcm9tIEpTXG53aW5kb3dbJ0JsYXpvciddID0ge1xuICBuYXZpZ2F0ZVRvLFxuXG4gIF9pbnRlcm5hbDoge1xuICAgIGF0dGFjaFJvb3RDb21wb25lbnRUb0VsZW1lbnQsXG4gICAgaHR0cDogaHR0cEludGVybmFsRnVuY3Rpb25zLFxuICAgIHVyaUhlbHBlcjogdXJpSGVscGVySW50ZXJuYWxGdW5jdGlvbnNcbiAgfVxufTtcbiIsImltcG9ydCB7IGdldEFzc2VtYmx5TmFtZUZyb21VcmwsIGdldEZpbGVOYW1lRnJvbVVybCB9IGZyb20gJy4uL1VybCc7XG5cbmNvbnN0IGN1cnJlbnRCcm93c2VySXNDaHJvbWUgPSAod2luZG93IGFzIGFueSkuY2hyb21lXG4gICYmIG5hdmlnYXRvci51c2VyQWdlbnQuaW5kZXhPZignRWRnZScpIDwgMDsgLy8gRWRnZSBwcmV0ZW5kcyB0byBiZSBDaHJvbWVcblxubGV0IGhhc1JlZmVyZW5jZWRQZGJzID0gZmFsc2U7XG5cbmV4cG9ydCBmdW5jdGlvbiBoYXNEZWJ1Z2dpbmdFbmFibGVkKCkge1xuICByZXR1cm4gaGFzUmVmZXJlbmNlZFBkYnMgJiYgY3VycmVudEJyb3dzZXJJc0Nocm9tZTtcbn1cblxuZXhwb3J0IGZ1bmN0aW9uIGF0dGFjaERlYnVnZ2VySG90a2V5KGxvYWRBc3NlbWJseVVybHM6IHN0cmluZ1tdKSB7XG4gIGhhc1JlZmVyZW5jZWRQZGJzID0gbG9hZEFzc2VtYmx5VXJsc1xuICAgIC5zb21lKHVybCA9PiAvXFwucGRiJC8udGVzdChnZXRGaWxlTmFtZUZyb21VcmwodXJsKSkpO1xuXG4gIC8vIFVzZSB0aGUgY29tYmluYXRpb24gc2hpZnQrYWx0K0QgYmVjYXVzZSBpdCBpc24ndCB1c2VkIGJ5IHRoZSBtYWpvciBicm93c2Vyc1xuICAvLyBmb3IgYW55dGhpbmcgZWxzZSBieSBkZWZhdWx0XG4gIGNvbnN0IGFsdEtleU5hbWUgPSBuYXZpZ2F0b3IucGxhdGZvcm0ubWF0Y2goL15NYWMvaSkgPyAnQ21kJyA6ICdBbHQnO1xuICBpZiAoaGFzRGVidWdnaW5nRW5hYmxlZCgpKSB7XG4gICAgY29uc29sZS5pbmZvKGBEZWJ1Z2dpbmcgaG90a2V5OiBTaGlmdCske2FsdEtleU5hbWV9K0QgKHdoZW4gYXBwbGljYXRpb24gaGFzIGZvY3VzKWApO1xuICB9XG5cbiAgLy8gRXZlbiBpZiBkZWJ1Z2dpbmcgaXNuJ3QgZW5hYmxlZCwgd2UgcmVnaXN0ZXIgdGhlIGhvdGtleSBzbyB3ZSBjYW4gcmVwb3J0IHdoeSBpdCdzIG5vdCBlbmFibGVkXG4gIGRvY3VtZW50LmFkZEV2ZW50TGlzdGVuZXIoJ2tleWRvd24nLCBldnQgPT4ge1xuICAgIGlmIChldnQuc2hpZnRLZXkgJiYgKGV2dC5tZXRhS2V5IHx8IGV2dC5hbHRLZXkpICYmIGV2dC5jb2RlID09PSAnS2V5RCcpIHtcbiAgICAgIGlmICghaGFzUmVmZXJlbmNlZFBkYnMpIHtcbiAgICAgICAgY29uc29sZS5lcnJvcignQ2Fubm90IHN0YXJ0IGRlYnVnZ2luZywgYmVjYXVzZSB0aGUgYXBwbGljYXRpb24gd2FzIG5vdCBjb21waWxlZCB3aXRoIGRlYnVnZ2luZyBlbmFibGVkLicpO1xuICAgICAgfSBlbHNlIGlmICghY3VycmVudEJyb3dzZXJJc0Nocm9tZSkge1xuICAgICAgICBjb25zb2xlLmVycm9yKCdDdXJyZW50bHksIG9ubHkgQ2hyb21lIGlzIHN1cHBvcnRlZCBmb3IgZGVidWdnaW5nLicpO1xuICAgICAgfSBlbHNlIHtcbiAgICAgICAgbGF1bmNoRGVidWdnZXIoKTtcbiAgICAgIH1cbiAgICB9XG4gIH0pO1xufVxuXG5mdW5jdGlvbiBsYXVuY2hEZWJ1Z2dlcigpIHtcbiAgLy8gVGhlIG5vb3BlbmVyIGZsYWcgaXMgZXNzZW50aWFsLCBiZWNhdXNlIG90aGVyd2lzZSBDaHJvbWUgdHJhY2tzIHRoZSBhc3NvY2lhdGlvbiB3aXRoIHRoZVxuICAvLyBwYXJlbnQgdGFiLCBhbmQgdGhlbiB3aGVuIHRoZSBwYXJlbnQgdGFiIHBhdXNlcyBpbiB0aGUgZGVidWdnZXIsIHRoZSBjaGlsZCB0YWIgZG9lcyBzb1xuICAvLyB0b28gKGV2ZW4gaWYgaXQncyBzaW5jZSBuYXZpZ2F0ZWQgdG8gYSBkaWZmZXJlbnQgcGFnZSkuIFRoaXMgbWVhbnMgdGhhdCB0aGUgZGVidWdnZXJcbiAgLy8gaXRzZWxmIGZyZWV6ZXMsIGFuZCBub3QganVzdCB0aGUgcGFnZSBiZWluZyBkZWJ1Z2dlZC5cbiAgLy9cbiAgLy8gV2UgaGF2ZSB0byBjb25zdHJ1Y3QgYSBsaW5rIGVsZW1lbnQgYW5kIHNpbXVsYXRlIGEgY2xpY2sgb24gaXQsIGJlY2F1c2UgdGhlIG1vcmUgb2J2aW91c1xuICAvLyB3aW5kb3cub3BlbiguLi4sICdub29wZW5lcicpIGFsd2F5cyBvcGVucyBhIG5ldyB3aW5kb3cgaW5zdGVhZCBvZiBhIG5ldyB0YWIuXG4gIGNvbnN0IGxpbmsgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdhJyk7XG4gIGxpbmsuaHJlZiA9IGBfZnJhbWV3b3JrL2RlYnVnP3VybD0ke2VuY29kZVVSSUNvbXBvbmVudChsb2NhdGlvbi5ocmVmKX1gO1xuICBsaW5rLnRhcmdldCA9ICdfYmxhbmsnO1xuICBsaW5rLnJlbCA9ICdub29wZW5lciBub3JlZmVycmVyJztcbiAgbGluay5jbGljaygpO1xufVxuIiwiaW1wb3J0IHsgTWV0aG9kSGFuZGxlLCBTeXN0ZW1fT2JqZWN0LCBTeXN0ZW1fU3RyaW5nLCBTeXN0ZW1fQXJyYXksIFBvaW50ZXIsIFBsYXRmb3JtIH0gZnJvbSAnLi4vUGxhdGZvcm0nO1xuaW1wb3J0IHsgZ2V0RmlsZU5hbWVGcm9tVXJsIH0gZnJvbSAnLi4vVXJsJztcbmltcG9ydCB7IGF0dGFjaERlYnVnZ2VySG90a2V5LCBoYXNEZWJ1Z2dpbmdFbmFibGVkIH0gZnJvbSAnLi9Nb25vRGVidWdnZXInO1xuXG5jb25zdCBhc3NlbWJseUhhbmRsZUNhY2hlOiB7IFthc3NlbWJseU5hbWU6IHN0cmluZ106IG51bWJlciB9ID0ge307XG5jb25zdCB0eXBlSGFuZGxlQ2FjaGU6IHsgW2Z1bGx5UXVhbGlmaWVkVHlwZU5hbWU6IHN0cmluZ106IG51bWJlciB9ID0ge307XG5jb25zdCBtZXRob2RIYW5kbGVDYWNoZTogeyBbZnVsbHlRdWFsaWZpZWRNZXRob2ROYW1lOiBzdHJpbmddOiBNZXRob2RIYW5kbGUgfSA9IHt9O1xuXG5sZXQgYXNzZW1ibHlfbG9hZDogKGFzc2VtYmx5TmFtZTogc3RyaW5nKSA9PiBudW1iZXI7XG5sZXQgZmluZF9jbGFzczogKGFzc2VtYmx5SGFuZGxlOiBudW1iZXIsIG5hbWVzcGFjZTogc3RyaW5nLCBjbGFzc05hbWU6IHN0cmluZykgPT4gbnVtYmVyO1xubGV0IGZpbmRfbWV0aG9kOiAodHlwZUhhbmRsZTogbnVtYmVyLCBtZXRob2ROYW1lOiBzdHJpbmcsIHVua25vd25Bcmc6IG51bWJlcikgPT4gTWV0aG9kSGFuZGxlO1xubGV0IGludm9rZV9tZXRob2Q6IChtZXRob2Q6IE1ldGhvZEhhbmRsZSwgdGFyZ2V0OiBTeXN0ZW1fT2JqZWN0LCBhcmdzQXJyYXlQdHI6IG51bWJlciwgZXhjZXB0aW9uRmxhZ0ludFB0cjogbnVtYmVyKSA9PiBTeXN0ZW1fT2JqZWN0O1xubGV0IG1vbm9fc3RyaW5nX2dldF91dGY4OiAobWFuYWdlZFN0cmluZzogU3lzdGVtX1N0cmluZykgPT4gTW9uby5VdGY4UHRyO1xubGV0IG1vbm9fc3RyaW5nOiAoanNTdHJpbmc6IHN0cmluZykgPT4gU3lzdGVtX1N0cmluZztcbmNvbnN0IGFwcEJpbkRpck5hbWUgPSAnYXBwQmluRGlyJztcblxuZXhwb3J0IGNvbnN0IG1vbm9QbGF0Zm9ybTogUGxhdGZvcm0gPSB7XG4gIHN0YXJ0OiBmdW5jdGlvbiBzdGFydChsb2FkQXNzZW1ibHlVcmxzOiBzdHJpbmdbXSkge1xuICAgIHJldHVybiBuZXcgUHJvbWlzZTx2b2lkPigocmVzb2x2ZSwgcmVqZWN0KSA9PiB7XG4gICAgICBhdHRhY2hEZWJ1Z2dlckhvdGtleShsb2FkQXNzZW1ibHlVcmxzKTtcblxuICAgICAgLy8gbW9uby5qcyBhc3N1bWVzIHRoZSBleGlzdGVuY2Ugb2YgdGhpc1xuICAgICAgd2luZG93WydCcm93c2VyJ10gPSB7XG4gICAgICAgIGluaXQ6ICgpID0+IHsgfVxuICAgICAgfTtcbiAgICAgIC8vIEVtc2NyaXB0ZW4gd29ya3MgYnkgZXhwZWN0aW5nIHRoZSBtb2R1bGUgY29uZmlnIHRvIGJlIGEgZ2xvYmFsXG4gICAgICB3aW5kb3dbJ01vZHVsZSddID0gY3JlYXRlRW1zY3JpcHRlbk1vZHVsZUluc3RhbmNlKGxvYWRBc3NlbWJseVVybHMsIHJlc29sdmUsIHJlamVjdCk7XG5cbiAgICAgIGFkZFNjcmlwdFRhZ3NUb0RvY3VtZW50KCk7XG4gICAgfSk7XG4gIH0sXG5cbiAgZmluZE1ldGhvZDogZmluZE1ldGhvZCxcblxuICBjYWxsRW50cnlQb2ludDogZnVuY3Rpb24gY2FsbEVudHJ5UG9pbnQoYXNzZW1ibHlOYW1lOiBzdHJpbmcsIGVudHJ5cG9pbnRNZXRob2Q6IHN0cmluZywgYXJnczogU3lzdGVtX09iamVjdFtdKTogdm9pZCB7XG4gICAgLy8gUGFyc2UgdGhlIGVudHJ5cG9pbnRNZXRob2QsIHdoaWNoIGlzIG9mIHRoZSBmb3JtIE15QXBwLk15TmFtZXNwYWNlLk15VHlwZU5hbWU6Ok15TWV0aG9kTmFtZVxuICAgIC8vIE5vdGUgdGhhdCB3ZSBkb24ndCBzdXBwb3J0IHNwZWNpZnlpbmcgYSBtZXRob2Qgb3ZlcmxvYWQsIHNvIGl0IGhhcyB0byBiZSB1bmlxdWVcbiAgICBjb25zdCBlbnRyeXBvaW50U2VnbWVudHMgPSBlbnRyeXBvaW50TWV0aG9kLnNwbGl0KCc6OicpO1xuICAgIGlmIChlbnRyeXBvaW50U2VnbWVudHMubGVuZ3RoICE9IDIpIHtcbiAgICAgIHRocm93IG5ldyBFcnJvcignTWFsZm9ybWVkIGVudHJ5IHBvaW50IG1ldGhvZCBuYW1lOyBjb3VsZCBub3QgcmVzb2x2ZSBjbGFzcyBuYW1lIGFuZCBtZXRob2QgbmFtZS4nKTtcbiAgICB9XG4gICAgY29uc3QgdHlwZUZ1bGxOYW1lID0gZW50cnlwb2ludFNlZ21lbnRzWzBdO1xuICAgIGNvbnN0IG1ldGhvZE5hbWUgPSBlbnRyeXBvaW50U2VnbWVudHNbMV07XG4gICAgY29uc3QgbGFzdERvdCA9IHR5cGVGdWxsTmFtZS5sYXN0SW5kZXhPZignLicpO1xuICAgIGNvbnN0IG5hbWVzcGFjZSA9IGxhc3REb3QgPiAtMSA/IHR5cGVGdWxsTmFtZS5zdWJzdHJpbmcoMCwgbGFzdERvdCkgOiAnJztcbiAgICBjb25zdCB0eXBlU2hvcnROYW1lID0gbGFzdERvdCA+IC0xID8gdHlwZUZ1bGxOYW1lLnN1YnN0cmluZyhsYXN0RG90ICsgMSkgOiB0eXBlRnVsbE5hbWU7XG5cbiAgICBjb25zdCBlbnRyeVBvaW50TWV0aG9kSGFuZGxlID0gbW9ub1BsYXRmb3JtLmZpbmRNZXRob2QoYXNzZW1ibHlOYW1lLCBuYW1lc3BhY2UsIHR5cGVTaG9ydE5hbWUsIG1ldGhvZE5hbWUpO1xuICAgIG1vbm9QbGF0Zm9ybS5jYWxsTWV0aG9kKGVudHJ5UG9pbnRNZXRob2RIYW5kbGUsIG51bGwsIGFyZ3MpO1xuICB9LFxuXG4gIGNhbGxNZXRob2Q6IGZ1bmN0aW9uIGNhbGxNZXRob2QobWV0aG9kOiBNZXRob2RIYW5kbGUsIHRhcmdldDogU3lzdGVtX09iamVjdCwgYXJnczogU3lzdGVtX09iamVjdFtdKTogU3lzdGVtX09iamVjdCB7XG4gICAgaWYgKGFyZ3MubGVuZ3RoID4gNCkge1xuICAgICAgLy8gSG9wZWZ1bGx5IHRoaXMgcmVzdHJpY3Rpb24gY2FuIGJlIGVhc2VkIHNvb24sIGJ1dCBmb3Igbm93IG1ha2UgaXQgY2xlYXIgd2hhdCdzIGdvaW5nIG9uXG4gICAgICB0aHJvdyBuZXcgRXJyb3IoYEN1cnJlbnRseSwgTW9ub1BsYXRmb3JtIHN1cHBvcnRzIHBhc3NpbmcgYSBtYXhpbXVtIG9mIDQgYXJndW1lbnRzIGZyb20gSlMgdG8gLk5FVC4gWW91IHRyaWVkIHRvIHBhc3MgJHthcmdzLmxlbmd0aH0uYCk7XG4gICAgfVxuXG4gICAgY29uc3Qgc3RhY2sgPSBNb2R1bGUuc3RhY2tTYXZlKCk7XG5cbiAgICB0cnkge1xuICAgICAgY29uc3QgYXJnc0J1ZmZlciA9IE1vZHVsZS5zdGFja0FsbG9jKGFyZ3MubGVuZ3RoKTtcbiAgICAgIGNvbnN0IGV4Y2VwdGlvbkZsYWdNYW5hZ2VkSW50ID0gTW9kdWxlLnN0YWNrQWxsb2MoNCk7XG4gICAgICBmb3IgKHZhciBpID0gMDsgaSA8IGFyZ3MubGVuZ3RoOyArK2kpIHtcbiAgICAgICAgTW9kdWxlLnNldFZhbHVlKGFyZ3NCdWZmZXIgKyBpICogNCwgYXJnc1tpXSwgJ2kzMicpO1xuICAgICAgfVxuICAgICAgTW9kdWxlLnNldFZhbHVlKGV4Y2VwdGlvbkZsYWdNYW5hZ2VkSW50LCAwLCAnaTMyJyk7XG5cbiAgICAgIGNvbnN0IHJlcyA9IGludm9rZV9tZXRob2QobWV0aG9kLCB0YXJnZXQsIGFyZ3NCdWZmZXIsIGV4Y2VwdGlvbkZsYWdNYW5hZ2VkSW50KTtcblxuICAgICAgaWYgKE1vZHVsZS5nZXRWYWx1ZShleGNlcHRpb25GbGFnTWFuYWdlZEludCwgJ2kzMicpICE9PSAwKSB7XG4gICAgICAgIC8vIElmIHRoZSBleGNlcHRpb24gZmxhZyBpcyBzZXQsIHRoZSByZXR1cm5lZCB2YWx1ZSBpcyBleGNlcHRpb24uVG9TdHJpbmcoKVxuICAgICAgICB0aHJvdyBuZXcgRXJyb3IobW9ub1BsYXRmb3JtLnRvSmF2YVNjcmlwdFN0cmluZyg8U3lzdGVtX1N0cmluZz5yZXMpKTtcbiAgICAgIH1cblxuICAgICAgcmV0dXJuIHJlcztcbiAgICB9IGZpbmFsbHkge1xuICAgICAgTW9kdWxlLnN0YWNrUmVzdG9yZShzdGFjayk7XG4gICAgfVxuICB9LFxuXG4gIHRvSmF2YVNjcmlwdFN0cmluZzogZnVuY3Rpb24gdG9KYXZhU2NyaXB0U3RyaW5nKG1hbmFnZWRTdHJpbmc6IFN5c3RlbV9TdHJpbmcpIHtcbiAgICAvLyBDb21tZW50cyBmcm9tIG9yaWdpbmFsIE1vbm8gc2FtcGxlOlxuICAgIC8vRklYTUUgdGhpcyBpcyB3YXN0ZWZ1bGwsIHdlIGNvdWxkIHJlbW92ZSB0aGUgdGVtcCBtYWxsb2MgYnkgZ29pbmcgdGhlIFVURjE2IHJvdXRlXG4gICAgLy9GSVhNRSB0aGlzIGlzIHVuc2FmZSwgY3V6IHJhdyBvYmplY3RzIGNvdWxkIGJlIEdDJ2QuXG5cbiAgICBjb25zdCB1dGY4ID0gbW9ub19zdHJpbmdfZ2V0X3V0ZjgobWFuYWdlZFN0cmluZyk7XG4gICAgY29uc3QgcmVzID0gTW9kdWxlLlVURjhUb1N0cmluZyh1dGY4KTtcbiAgICBNb2R1bGUuX2ZyZWUodXRmOCBhcyBhbnkpO1xuICAgIHJldHVybiByZXM7XG4gIH0sXG5cbiAgdG9Eb3ROZXRTdHJpbmc6IGZ1bmN0aW9uIHRvRG90TmV0U3RyaW5nKGpzU3RyaW5nOiBzdHJpbmcpOiBTeXN0ZW1fU3RyaW5nIHtcbiAgICByZXR1cm4gbW9ub19zdHJpbmcoanNTdHJpbmcpO1xuICB9LFxuXG4gIHRvVWludDhBcnJheTogZnVuY3Rpb24gdG9VaW50OEFycmF5KGFycmF5OiBTeXN0ZW1fQXJyYXk8YW55Pik6IFVpbnQ4QXJyYXkge1xuICAgIGNvbnN0IGRhdGFQdHIgPSBnZXRBcnJheURhdGFQb2ludGVyKGFycmF5KTtcbiAgICBjb25zdCBsZW5ndGggPSBNb2R1bGUuZ2V0VmFsdWUoZGF0YVB0ciwgJ2kzMicpO1xuICAgIHJldHVybiBuZXcgVWludDhBcnJheShNb2R1bGUuSEVBUFU4LmJ1ZmZlciwgZGF0YVB0ciArIDQsIGxlbmd0aCk7XG4gIH0sXG5cbiAgZ2V0QXJyYXlMZW5ndGg6IGZ1bmN0aW9uIGdldEFycmF5TGVuZ3RoKGFycmF5OiBTeXN0ZW1fQXJyYXk8YW55Pik6IG51bWJlciB7XG4gICAgcmV0dXJuIE1vZHVsZS5nZXRWYWx1ZShnZXRBcnJheURhdGFQb2ludGVyKGFycmF5KSwgJ2kzMicpO1xuICB9LFxuXG4gIGdldEFycmF5RW50cnlQdHI6IGZ1bmN0aW9uIGdldEFycmF5RW50cnlQdHI8VFB0ciBleHRlbmRzIFBvaW50ZXI+KGFycmF5OiBTeXN0ZW1fQXJyYXk8VFB0cj4sIGluZGV4OiBudW1iZXIsIGl0ZW1TaXplOiBudW1iZXIpOiBUUHRyIHtcbiAgICAvLyBGaXJzdCBieXRlIGlzIGFycmF5IGxlbmd0aCwgZm9sbG93ZWQgYnkgZW50cmllc1xuICAgIGNvbnN0IGFkZHJlc3MgPSBnZXRBcnJheURhdGFQb2ludGVyKGFycmF5KSArIDQgKyBpbmRleCAqIGl0ZW1TaXplO1xuICAgIHJldHVybiBhZGRyZXNzIGFzIGFueSBhcyBUUHRyO1xuICB9LFxuXG4gIGdldE9iamVjdEZpZWxkc0Jhc2VBZGRyZXNzOiBmdW5jdGlvbiBnZXRPYmplY3RGaWVsZHNCYXNlQWRkcmVzcyhyZWZlcmVuY2VUeXBlZE9iamVjdDogU3lzdGVtX09iamVjdCk6IFBvaW50ZXIge1xuICAgIC8vIFRoZSBmaXJzdCB0d28gaW50MzIgdmFsdWVzIGFyZSBpbnRlcm5hbCBNb25vIGRhdGFcbiAgICByZXR1cm4gKHJlZmVyZW5jZVR5cGVkT2JqZWN0IGFzIGFueSBhcyBudW1iZXIgKyA4KSBhcyBhbnkgYXMgUG9pbnRlcjtcbiAgfSxcblxuICByZWFkSW50MzJGaWVsZDogZnVuY3Rpb24gcmVhZEhlYXBJbnQzMihiYXNlQWRkcmVzczogUG9pbnRlciwgZmllbGRPZmZzZXQ/OiBudW1iZXIpOiBudW1iZXIge1xuICAgIHJldHVybiBNb2R1bGUuZ2V0VmFsdWUoKGJhc2VBZGRyZXNzIGFzIGFueSBhcyBudW1iZXIpICsgKGZpZWxkT2Zmc2V0IHx8IDApLCAnaTMyJyk7XG4gIH0sXG5cbiAgcmVhZEZsb2F0RmllbGQ6IGZ1bmN0aW9uIHJlYWRIZWFwRmxvYXQoYmFzZUFkZHJlc3M6IFBvaW50ZXIsIGZpZWxkT2Zmc2V0PzogbnVtYmVyKTogbnVtYmVyIHtcbiAgICByZXR1cm4gTW9kdWxlLmdldFZhbHVlKChiYXNlQWRkcmVzcyBhcyBhbnkgYXMgbnVtYmVyKSArIChmaWVsZE9mZnNldCB8fCAwKSwgJ2Zsb2F0Jyk7XG4gIH0sXG5cbiAgcmVhZE9iamVjdEZpZWxkOiBmdW5jdGlvbiByZWFkSGVhcE9iamVjdDxUIGV4dGVuZHMgU3lzdGVtX09iamVjdD4oYmFzZUFkZHJlc3M6IFBvaW50ZXIsIGZpZWxkT2Zmc2V0PzogbnVtYmVyKTogVCB7XG4gICAgcmV0dXJuIE1vZHVsZS5nZXRWYWx1ZSgoYmFzZUFkZHJlc3MgYXMgYW55IGFzIG51bWJlcikgKyAoZmllbGRPZmZzZXQgfHwgMCksICdpMzInKSBhcyBhbnkgYXMgVDtcbiAgfSxcblxuICByZWFkU3RyaW5nRmllbGQ6IGZ1bmN0aW9uIHJlYWRIZWFwT2JqZWN0KGJhc2VBZGRyZXNzOiBQb2ludGVyLCBmaWVsZE9mZnNldD86IG51bWJlcik6IHN0cmluZyB8IG51bGwge1xuICAgIGNvbnN0IGZpZWxkVmFsdWUgPSBNb2R1bGUuZ2V0VmFsdWUoKGJhc2VBZGRyZXNzIGFzIGFueSBhcyBudW1iZXIpICsgKGZpZWxkT2Zmc2V0IHx8IDApLCAnaTMyJyk7XG4gICAgcmV0dXJuIGZpZWxkVmFsdWUgPT09IDAgPyBudWxsIDogbW9ub1BsYXRmb3JtLnRvSmF2YVNjcmlwdFN0cmluZyhmaWVsZFZhbHVlIGFzIGFueSBhcyBTeXN0ZW1fU3RyaW5nKTtcbiAgfSxcblxuICByZWFkU3RydWN0RmllbGQ6IGZ1bmN0aW9uIHJlYWRTdHJ1Y3RGaWVsZDxUIGV4dGVuZHMgUG9pbnRlcj4oYmFzZUFkZHJlc3M6IFBvaW50ZXIsIGZpZWxkT2Zmc2V0PzogbnVtYmVyKTogVCB7XG4gICAgcmV0dXJuICgoYmFzZUFkZHJlc3MgYXMgYW55IGFzIG51bWJlcikgKyAoZmllbGRPZmZzZXQgfHwgMCkpIGFzIGFueSBhcyBUO1xuICB9LFxufTtcblxuZnVuY3Rpb24gZmluZEFzc2VtYmx5KGFzc2VtYmx5TmFtZTogc3RyaW5nKTogbnVtYmVyIHtcbiAgbGV0IGFzc2VtYmx5SGFuZGxlID0gYXNzZW1ibHlIYW5kbGVDYWNoZVthc3NlbWJseU5hbWVdO1xuICBpZiAoIWFzc2VtYmx5SGFuZGxlKSB7XG4gICAgYXNzZW1ibHlIYW5kbGUgPSBhc3NlbWJseV9sb2FkKGFzc2VtYmx5TmFtZSk7XG4gICAgaWYgKCFhc3NlbWJseUhhbmRsZSkge1xuICAgICAgdGhyb3cgbmV3IEVycm9yKGBDb3VsZCBub3QgZmluZCBhc3NlbWJseSBcIiR7YXNzZW1ibHlOYW1lfVwiYCk7XG4gICAgfVxuICAgIGFzc2VtYmx5SGFuZGxlQ2FjaGVbYXNzZW1ibHlOYW1lXSA9IGFzc2VtYmx5SGFuZGxlO1xuICB9XG4gIHJldHVybiBhc3NlbWJseUhhbmRsZTtcbn1cblxuZnVuY3Rpb24gZmluZFR5cGUoYXNzZW1ibHlOYW1lOiBzdHJpbmcsIG5hbWVzcGFjZTogc3RyaW5nLCBjbGFzc05hbWU6IHN0cmluZyk6IG51bWJlciB7XG4gIGNvbnN0IGZ1bGx5UXVhbGlmaWVkVHlwZU5hbWUgPSBgWyR7YXNzZW1ibHlOYW1lfV0ke25hbWVzcGFjZX0uJHtjbGFzc05hbWV9YDtcbiAgbGV0IHR5cGVIYW5kbGUgPSB0eXBlSGFuZGxlQ2FjaGVbZnVsbHlRdWFsaWZpZWRUeXBlTmFtZV07XG4gIGlmICghdHlwZUhhbmRsZSkge1xuICAgIHR5cGVIYW5kbGUgPSBmaW5kX2NsYXNzKGZpbmRBc3NlbWJseShhc3NlbWJseU5hbWUpLCBuYW1lc3BhY2UsIGNsYXNzTmFtZSk7XG4gICAgaWYgKCF0eXBlSGFuZGxlKSB7XG4gICAgICB0aHJvdyBuZXcgRXJyb3IoYENvdWxkIG5vdCBmaW5kIHR5cGUgXCIke2NsYXNzTmFtZX1cIiBpbiBuYW1lc3BhY2UgXCIke25hbWVzcGFjZX1cIiBpbiBhc3NlbWJseSBcIiR7YXNzZW1ibHlOYW1lfVwiYCk7XG4gICAgfVxuICAgIHR5cGVIYW5kbGVDYWNoZVtmdWxseVF1YWxpZmllZFR5cGVOYW1lXSA9IHR5cGVIYW5kbGU7XG4gIH1cbiAgcmV0dXJuIHR5cGVIYW5kbGU7XG59XG5cbmZ1bmN0aW9uIGZpbmRNZXRob2QoYXNzZW1ibHlOYW1lOiBzdHJpbmcsIG5hbWVzcGFjZTogc3RyaW5nLCBjbGFzc05hbWU6IHN0cmluZywgbWV0aG9kTmFtZTogc3RyaW5nKTogTWV0aG9kSGFuZGxlIHtcbiAgY29uc3QgZnVsbHlRdWFsaWZpZWRNZXRob2ROYW1lID0gYFske2Fzc2VtYmx5TmFtZX1dJHtuYW1lc3BhY2V9LiR7Y2xhc3NOYW1lfTo6JHttZXRob2ROYW1lfWA7XG4gIGxldCBtZXRob2RIYW5kbGUgPSBtZXRob2RIYW5kbGVDYWNoZVtmdWxseVF1YWxpZmllZE1ldGhvZE5hbWVdO1xuICBpZiAoIW1ldGhvZEhhbmRsZSkge1xuICAgIG1ldGhvZEhhbmRsZSA9IGZpbmRfbWV0aG9kKGZpbmRUeXBlKGFzc2VtYmx5TmFtZSwgbmFtZXNwYWNlLCBjbGFzc05hbWUpLCBtZXRob2ROYW1lLCAtMSk7XG4gICAgaWYgKCFtZXRob2RIYW5kbGUpIHtcbiAgICAgIHRocm93IG5ldyBFcnJvcihgQ291bGQgbm90IGZpbmQgbWV0aG9kIFwiJHttZXRob2ROYW1lfVwiIG9uIHR5cGUgXCIke25hbWVzcGFjZX0uJHtjbGFzc05hbWV9XCJgKTtcbiAgICB9XG4gICAgbWV0aG9kSGFuZGxlQ2FjaGVbZnVsbHlRdWFsaWZpZWRNZXRob2ROYW1lXSA9IG1ldGhvZEhhbmRsZTtcbiAgfVxuICByZXR1cm4gbWV0aG9kSGFuZGxlO1xufVxuXG5mdW5jdGlvbiBhZGRTY3JpcHRUYWdzVG9Eb2N1bWVudCgpIHtcbiAgY29uc3QgYnJvd3NlclN1cHBvcnRzTmF0aXZlV2ViQXNzZW1ibHkgPSB0eXBlb2YgV2ViQXNzZW1ibHkgIT09ICd1bmRlZmluZWQnICYmIFdlYkFzc2VtYmx5LnZhbGlkYXRlO1xuICBpZiAoIWJyb3dzZXJTdXBwb3J0c05hdGl2ZVdlYkFzc2VtYmx5KSB7XG4gICAgdGhyb3cgbmV3IEVycm9yKCdUaGlzIGJyb3dzZXIgZG9lcyBub3Qgc3VwcG9ydCBXZWJBc3NlbWJseS4nKTtcbiAgfVxuXG4gIGNvbnN0IHNjcmlwdEVsZW0gPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdzY3JpcHQnKTtcbiAgc2NyaXB0RWxlbS5zcmMgPSAnX2ZyYW1ld29yay93YXNtL21vbm8uanMnO1xuICBzY3JpcHRFbGVtLmRlZmVyID0gdHJ1ZTtcbiAgZG9jdW1lbnQuYm9keS5hcHBlbmRDaGlsZChzY3JpcHRFbGVtKTtcbn1cblxuZnVuY3Rpb24gY3JlYXRlRW1zY3JpcHRlbk1vZHVsZUluc3RhbmNlKGxvYWRBc3NlbWJseVVybHM6IHN0cmluZ1tdLCBvblJlYWR5OiAoKSA9PiB2b2lkLCBvbkVycm9yOiAocmVhc29uPzogYW55KSA9PiB2b2lkKSB7XG4gIGNvbnN0IG1vZHVsZSA9IHt9IGFzIHR5cGVvZiBNb2R1bGU7XG4gIGNvbnN0IHdhc21CaW5hcnlGaWxlID0gJ19mcmFtZXdvcmsvd2FzbS9tb25vLndhc20nO1xuICBjb25zdCBzdXBwcmVzc01lc3NhZ2VzID0gWydERUJVR0dJTkcgRU5BQkxFRCddO1xuXG4gIG1vZHVsZS5wcmludCA9IGxpbmUgPT4gKHN1cHByZXNzTWVzc2FnZXMuaW5kZXhPZihsaW5lKSA8IDAgJiYgY29uc29sZS5sb2coYFdBU006ICR7bGluZX1gKSk7XG4gIG1vZHVsZS5wcmludEVyciA9IGxpbmUgPT4gY29uc29sZS5lcnJvcihgV0FTTTogJHtsaW5lfWApO1xuICBtb2R1bGUucHJlUnVuID0gW107XG4gIG1vZHVsZS5wb3N0UnVuID0gW107XG4gIG1vZHVsZS5wcmVsb2FkUGx1Z2lucyA9IFtdO1xuXG4gIG1vZHVsZS5sb2NhdGVGaWxlID0gZmlsZU5hbWUgPT4ge1xuICAgIHN3aXRjaCAoZmlsZU5hbWUpIHtcbiAgICAgIGNhc2UgJ21vbm8ud2FzbSc6IHJldHVybiB3YXNtQmluYXJ5RmlsZTtcbiAgICAgIGRlZmF1bHQ6IHJldHVybiBmaWxlTmFtZTtcbiAgICB9XG4gIH07XG5cbiAgbW9kdWxlLnByZVJ1bi5wdXNoKCgpID0+IHtcbiAgICAvLyBCeSBub3csIGVtc2NyaXB0ZW4gc2hvdWxkIGJlIGluaXRpYWxpc2VkIGVub3VnaCB0aGF0IHdlIGNhbiBjYXB0dXJlIHRoZXNlIG1ldGhvZHMgZm9yIGxhdGVyIHVzZVxuICAgIGNvbnN0IG1vbm9fd2FzbV9hZGRfYXNzZW1ibHkgPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9hZGRfYXNzZW1ibHknLCBudWxsLCBbJ3N0cmluZycsICdudW1iZXInLCAnbnVtYmVyJ10pO1xuICAgIGFzc2VtYmx5X2xvYWQgPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9hc3NlbWJseV9sb2FkJywgJ251bWJlcicsIFsnc3RyaW5nJ10pO1xuICAgIGZpbmRfY2xhc3MgPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9hc3NlbWJseV9maW5kX2NsYXNzJywgJ251bWJlcicsIFsnbnVtYmVyJywgJ3N0cmluZycsICdzdHJpbmcnXSk7XG4gICAgZmluZF9tZXRob2QgPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9hc3NlbWJseV9maW5kX21ldGhvZCcsICdudW1iZXInLCBbJ251bWJlcicsICdzdHJpbmcnLCAnbnVtYmVyJ10pO1xuICAgIGludm9rZV9tZXRob2QgPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9pbnZva2VfbWV0aG9kJywgJ251bWJlcicsIFsnbnVtYmVyJywgJ251bWJlcicsICdudW1iZXInXSk7XG4gICAgbW9ub19zdHJpbmdfZ2V0X3V0ZjggPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9zdHJpbmdfZ2V0X3V0ZjgnLCAnbnVtYmVyJywgWydudW1iZXInXSk7XG4gICAgbW9ub19zdHJpbmcgPSBNb2R1bGUuY3dyYXAoJ21vbm9fd2FzbV9zdHJpbmdfZnJvbV9qcycsICdudW1iZXInLCBbJ3N0cmluZyddKTtcblxuICAgIE1PTk8ubG9hZGVkX2ZpbGVzID0gW107XG5cbiAgICBsb2FkQXNzZW1ibHlVcmxzLmZvckVhY2godXJsID0+IHtcbiAgICAgIGNvbnN0IGZpbGVuYW1lID0gZ2V0RmlsZU5hbWVGcm9tVXJsKHVybCk7XG4gICAgICBjb25zdCBydW5EZXBlbmRlbmN5SWQgPSBgYmxhem9yOiR7ZmlsZW5hbWV9YDtcbiAgICAgIGFkZFJ1bkRlcGVuZGVuY3kocnVuRGVwZW5kZW5jeUlkKTtcbiAgICAgIGFzeW5jTG9hZCh1cmwpLnRoZW4oXG4gICAgICAgIGRhdGEgPT4ge1xuICAgICAgICAgIGNvbnN0IGhlYXBBZGRyZXNzID0gTW9kdWxlLl9tYWxsb2MoZGF0YS5sZW5ndGgpO1xuICAgICAgICAgIGNvbnN0IGhlYXBNZW1vcnkgPSBuZXcgVWludDhBcnJheShNb2R1bGUuSEVBUFU4LmJ1ZmZlciwgaGVhcEFkZHJlc3MsIGRhdGEubGVuZ3RoKTtcbiAgICAgICAgICBoZWFwTWVtb3J5LnNldChkYXRhKTtcbiAgICAgICAgICBtb25vX3dhc21fYWRkX2Fzc2VtYmx5KGZpbGVuYW1lLCBoZWFwQWRkcmVzcywgZGF0YS5sZW5ndGgpO1xuICAgICAgICAgIE1PTk8ubG9hZGVkX2ZpbGVzLnB1c2godG9BYnNvbHV0ZVVybCh1cmwpKTtcbiAgICAgICAgICByZW1vdmVSdW5EZXBlbmRlbmN5KHJ1bkRlcGVuZGVuY3lJZCk7XG4gICAgICAgIH0sXG4gICAgICAgIGVycm9ySW5mbyA9PiB7XG4gICAgICAgICAgLy8gSWYgaXQncyBhIDQwNCBvbiBhIC5wZGIsIHdlIGRvbid0IHdhbnQgdG8gYmxvY2sgdGhlIGFwcCBmcm9tIHN0YXJ0aW5nIHVwLlxuICAgICAgICAgIC8vIFdlJ2xsIGp1c3Qgc2tpcCB0aGF0IGZpbGUgYW5kIGNvbnRpbnVlICh0aG91Z2ggdGhlIDQwNCBpcyBsb2dnZWQgaW4gdGhlIGNvbnNvbGUpLlxuICAgICAgICAgIC8vIFRoaXMgaGFwcGVucyBpZiB5b3UgYnVpbGQgYSBEZWJ1ZyBidWlsZCBidXQgdGhlbiBydW4gaW4gUHJvZHVjdGlvbiBlbnZpcm9ubWVudC5cbiAgICAgICAgICBjb25zdCBpc1BkYjQwNCA9IGVycm9ySW5mbyBpbnN0YW5jZW9mIFhNTEh0dHBSZXF1ZXN0XG4gICAgICAgICAgICAmJiBlcnJvckluZm8uc3RhdHVzID09PSA0MDRcbiAgICAgICAgICAgICYmIGZpbGVuYW1lLm1hdGNoKC9cXC5wZGIkLyk7XG4gICAgICAgICAgaWYgKCFpc1BkYjQwNCkge1xuICAgICAgICAgICAgb25FcnJvcihlcnJvckluZm8pO1xuICAgICAgICAgIH1cbiAgICAgICAgICByZW1vdmVSdW5EZXBlbmRlbmN5KHJ1bkRlcGVuZGVuY3lJZCk7XG4gICAgICAgIH1cbiAgICAgICk7XG4gICAgfSk7XG4gIH0pO1xuXG4gIG1vZHVsZS5wb3N0UnVuLnB1c2goKCkgPT4ge1xuICAgIGNvbnN0IGxvYWRfcnVudGltZSA9IE1vZHVsZS5jd3JhcCgnbW9ub193YXNtX2xvYWRfcnVudGltZScsIG51bGwsIFsnc3RyaW5nJywgJ251bWJlciddKTtcbiAgICBsb2FkX3J1bnRpbWUoYXBwQmluRGlyTmFtZSwgaGFzRGVidWdnaW5nRW5hYmxlZCgpID8gMSA6IDApO1xuICAgIE1PTk8ubW9ub193YXNtX3J1bnRpbWVfaXNfcmVhZHkgPSB0cnVlO1xuICAgIGF0dGFjaEludGVyb3BJbnZva2VyKCk7XG4gICAgb25SZWFkeSgpO1xuICB9KTtcblxuICByZXR1cm4gbW9kdWxlO1xufVxuXG5jb25zdCBhbmNob3JUYWdGb3JBYnNvbHV0ZVVybENvbnZlcnNpb25zID0gZG9jdW1lbnQuY3JlYXRlRWxlbWVudCgnYScpO1xuZnVuY3Rpb24gdG9BYnNvbHV0ZVVybChwb3NzaWJseVJlbGF0aXZlVXJsOiBzdHJpbmcpIHtcbiAgYW5jaG9yVGFnRm9yQWJzb2x1dGVVcmxDb252ZXJzaW9ucy5ocmVmID0gcG9zc2libHlSZWxhdGl2ZVVybDtcbiAgcmV0dXJuIGFuY2hvclRhZ0ZvckFic29sdXRlVXJsQ29udmVyc2lvbnMuaHJlZjtcbn1cblxuZnVuY3Rpb24gYXN5bmNMb2FkKHVybCkge1xuICByZXR1cm4gbmV3IFByb21pc2U8VWludDhBcnJheT4oKHJlc29sdmUsIHJlamVjdCkgPT4ge1xuICAgIHZhciB4aHIgPSBuZXcgWE1MSHR0cFJlcXVlc3Q7XG4gICAgeGhyLm9wZW4oJ0dFVCcsIHVybCwgLyogYXN5bmM6ICovIHRydWUpO1xuICAgIHhoci5yZXNwb25zZVR5cGUgPSAnYXJyYXlidWZmZXInO1xuICAgIHhoci5vbmxvYWQgPSBmdW5jdGlvbiB4aHJfb25sb2FkKCkge1xuICAgICAgaWYgKHhoci5zdGF0dXMgPT0gMjAwIHx8IHhoci5zdGF0dXMgPT0gMCAmJiB4aHIucmVzcG9uc2UpIHtcbiAgICAgICAgdmFyIGFzbSA9IG5ldyBVaW50OEFycmF5KHhoci5yZXNwb25zZSk7XG4gICAgICAgIHJlc29sdmUoYXNtKTtcbiAgICAgIH0gZWxzZSB7XG4gICAgICAgIHJlamVjdCh4aHIpO1xuICAgICAgfVxuICAgIH07XG4gICAgeGhyLm9uZXJyb3IgPSByZWplY3Q7XG4gICAgeGhyLnNlbmQodW5kZWZpbmVkKTtcbiAgfSk7XG59XG5cbmZ1bmN0aW9uIGdldEFycmF5RGF0YVBvaW50ZXI8VD4oYXJyYXk6IFN5c3RlbV9BcnJheTxUPik6IG51bWJlciB7XG4gIHJldHVybiA8bnVtYmVyPjxhbnk+YXJyYXkgKyAxMjsgLy8gRmlyc3QgYnl0ZSBmcm9tIGhlcmUgaXMgbGVuZ3RoLCB0aGVuIGZvbGxvd2luZyBieXRlcyBhcmUgZW50cmllc1xufVxuXG5mdW5jdGlvbiBhdHRhY2hJbnRlcm9wSW52b2tlcigpIHtcbiAgY29uc3QgZG90TmV0RGlzcGF0Y2hlckludm9rZU1ldGhvZEhhbmRsZSA9IGZpbmRNZXRob2QoJ01vbm8uV2ViQXNzZW1ibHkuSW50ZXJvcCcsICdNb25vLldlYkFzc2VtYmx5LkludGVyb3AnLCAnTW9ub1dlYkFzc2VtYmx5SlNSdW50aW1lJywgJ0ludm9rZURvdE5ldCcpO1xuICBjb25zdCBkb3ROZXREaXNwYXRjaGVyQmVnaW5JbnZva2VNZXRob2RIYW5kbGUgPSBmaW5kTWV0aG9kKCdNb25vLldlYkFzc2VtYmx5LkludGVyb3AnLCAnTW9uby5XZWJBc3NlbWJseS5JbnRlcm9wJywgJ01vbm9XZWJBc3NlbWJseUpTUnVudGltZScsICdCZWdpbkludm9rZURvdE5ldCcpO1xuXG4gIERvdE5ldC5hdHRhY2hEaXNwYXRjaGVyKHtcbiAgICBiZWdpbkludm9rZURvdE5ldEZyb21KUzogKGNhbGxJZCwgYXNzZW1ibHlOYW1lLCBtZXRob2RJZGVudGlmaWVyLCBkb3ROZXRPYmplY3RJZCwgYXJnc0pzb24pID0+IHtcbiAgICAgIC8vIEFzIGEgY3VycmVudCBsaW1pdGF0aW9uLCB3ZSBjYW4gb25seSBwYXNzIDQgYXJncy4gRm9ydHVuYXRlbHkgd2Ugb25seSBuZWVkIG9uZSBvZlxuICAgICAgLy8gJ2Fzc2VtYmx5TmFtZScgb3IgJ2RvdE5ldE9iamVjdElkJywgc28gb3ZlcmxvYWQgdGhlbSBpbiBhIHNpbmdsZSBzbG90XG4gICAgICBjb25zdCBhc3NlbWJseU5hbWVPckRvdE5ldE9iamVjdElkID0gZG90TmV0T2JqZWN0SWRcbiAgICAgICAgPyBkb3ROZXRPYmplY3RJZC50b1N0cmluZygpXG4gICAgICAgIDogYXNzZW1ibHlOYW1lO1xuICAgICAgXG4gICAgICBtb25vUGxhdGZvcm0uY2FsbE1ldGhvZChkb3ROZXREaXNwYXRjaGVyQmVnaW5JbnZva2VNZXRob2RIYW5kbGUsIG51bGwsIFtcbiAgICAgICAgY2FsbElkID8gbW9ub1BsYXRmb3JtLnRvRG90TmV0U3RyaW5nKGNhbGxJZC50b1N0cmluZygpKSA6IG51bGwsXG4gICAgICAgIG1vbm9QbGF0Zm9ybS50b0RvdE5ldFN0cmluZyhhc3NlbWJseU5hbWVPckRvdE5ldE9iamVjdElkISksXG4gICAgICAgIG1vbm9QbGF0Zm9ybS50b0RvdE5ldFN0cmluZyhtZXRob2RJZGVudGlmaWVyKSxcbiAgICAgICAgbW9ub1BsYXRmb3JtLnRvRG90TmV0U3RyaW5nKGFyZ3NKc29uKVxuICAgICAgXSk7XG4gICAgfSxcblxuICAgIGludm9rZURvdE5ldEZyb21KUzogKGFzc2VtYmx5TmFtZSwgbWV0aG9kSWRlbnRpZmllciwgZG90TmV0T2JqZWN0SWQsIGFyZ3NKc29uKSA9PiB7XG4gICAgICBjb25zdCByZXN1bHRKc29uU3RyaW5nUHRyID0gbW9ub1BsYXRmb3JtLmNhbGxNZXRob2QoZG90TmV0RGlzcGF0Y2hlckludm9rZU1ldGhvZEhhbmRsZSwgbnVsbCwgW1xuICAgICAgICBhc3NlbWJseU5hbWUgPyBtb25vUGxhdGZvcm0udG9Eb3ROZXRTdHJpbmcoYXNzZW1ibHlOYW1lKSA6IG51bGwsXG4gICAgICAgIG1vbm9QbGF0Zm9ybS50b0RvdE5ldFN0cmluZyhtZXRob2RJZGVudGlmaWVyKSxcbiAgICAgICAgZG90TmV0T2JqZWN0SWQgPyBtb25vUGxhdGZvcm0udG9Eb3ROZXRTdHJpbmcoZG90TmV0T2JqZWN0SWQudG9TdHJpbmcoKSkgOiBudWxsLFxuICAgICAgICBtb25vUGxhdGZvcm0udG9Eb3ROZXRTdHJpbmcoYXJnc0pzb24pXG4gICAgICBdKSBhcyBTeXN0ZW1fU3RyaW5nO1xuICAgICAgcmV0dXJuIHJlc3VsdEpzb25TdHJpbmdQdHJcbiAgICAgICAgPyBtb25vUGxhdGZvcm0udG9KYXZhU2NyaXB0U3RyaW5nKHJlc3VsdEpzb25TdHJpbmdQdHIpXG4gICAgICAgIDogbnVsbDtcbiAgICB9LFxuICB9KTtcbn1cbiIsImV4cG9ydCBmdW5jdGlvbiBnZXRGaWxlTmFtZUZyb21VcmwodXJsOiBzdHJpbmcpIHtcbiAgLy8gVGhpcyBjb3VsZCBhbHNvIGJlIGNhbGxlZCBcImdldCBsYXN0IHBhdGggc2VnbWVudCBmcm9tIFVSTFwiLCBidXQgdGhlIHByaW1hcnlcbiAgLy8gdXNlIGNhc2UgaXMgdG8gZXh0cmFjdCB0aGluZ3MgdGhhdCBsb29rIGxpa2UgZmlsZW5hbWVzXG4gIGNvbnN0IGxhc3RTZWdtZW50ID0gdXJsLnN1YnN0cmluZyh1cmwubGFzdEluZGV4T2YoJy8nKSArIDEpO1xuICBjb25zdCBxdWVyeVN0cmluZ1N0YXJ0UG9zID0gbGFzdFNlZ21lbnQuaW5kZXhPZignPycpO1xuICByZXR1cm4gcXVlcnlTdHJpbmdTdGFydFBvcyA8IDAgPyBsYXN0U2VnbWVudCA6IGxhc3RTZWdtZW50LnN1YnN0cmluZygwLCBxdWVyeVN0cmluZ1N0YXJ0UG9zKTtcbn1cblxuZXhwb3J0IGZ1bmN0aW9uIGdldEFzc2VtYmx5TmFtZUZyb21VcmwodXJsOiBzdHJpbmcpIHtcbiAgcmV0dXJuIGdldEZpbGVOYW1lRnJvbVVybCh1cmwpLnJlcGxhY2UoL1xcLmRsbCQvLCAnJyk7XG59XG4iLCJpbXBvcnQgeyBSZW5kZXJCYXRjaCwgQXJyYXlTZWdtZW50LCBSZW5kZXJUcmVlRWRpdCwgUmVuZGVyVHJlZUZyYW1lLCBFZGl0VHlwZSwgRnJhbWVUeXBlLCBBcnJheVZhbHVlcyB9IGZyb20gJy4vUmVuZGVyQmF0Y2gvUmVuZGVyQmF0Y2gnO1xuaW1wb3J0IHsgRXZlbnREZWxlZ2F0b3IgfSBmcm9tICcuL0V2ZW50RGVsZWdhdG9yJztcbmltcG9ydCB7IEV2ZW50Rm9yRG90TmV0LCBVSUV2ZW50QXJncyB9IGZyb20gJy4vRXZlbnRGb3JEb3ROZXQnO1xuaW1wb3J0IHsgTG9naWNhbEVsZW1lbnQsIHRvTG9naWNhbEVsZW1lbnQsIGluc2VydExvZ2ljYWxDaGlsZCwgcmVtb3ZlTG9naWNhbENoaWxkLCBnZXRMb2dpY2FsUGFyZW50LCBnZXRMb2dpY2FsQ2hpbGQsIGNyZWF0ZUFuZEluc2VydExvZ2ljYWxDb250YWluZXIsIGlzU3ZnRWxlbWVudCB9IGZyb20gJy4vTG9naWNhbEVsZW1lbnRzJztcbmltcG9ydCB7IGFwcGx5Q2FwdHVyZUlkVG9FbGVtZW50IH0gZnJvbSAnLi9FbGVtZW50UmVmZXJlbmNlQ2FwdHVyZSc7XG5jb25zdCBzZWxlY3RWYWx1ZVByb3BuYW1lID0gJ19ibGF6b3JTZWxlY3RWYWx1ZSc7XG5jb25zdCBzaGFyZWRUZW1wbGF0ZUVsZW1Gb3JQYXJzaW5nID0gZG9jdW1lbnQuY3JlYXRlRWxlbWVudCgndGVtcGxhdGUnKTtcbmNvbnN0IHNoYXJlZFN2Z0VsZW1Gb3JQYXJzaW5nID0gZG9jdW1lbnQuY3JlYXRlRWxlbWVudE5TKCdodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZycsICdnJyk7XG5jb25zdCBwcmV2ZW50RGVmYXVsdEV2ZW50czogeyBbZXZlbnRUeXBlOiBzdHJpbmddOiBib29sZWFuIH0gPSB7IHN1Ym1pdDogdHJ1ZSB9O1xuY29uc3Qgcm9vdENvbXBvbmVudHNQZW5kaW5nRmlyc3RSZW5kZXI6IHsgW2NvbXBvbmVudElkOiBudW1iZXJdOiBFbGVtZW50IH0gPSB7fTtcblxuZXhwb3J0IGNsYXNzIEJyb3dzZXJSZW5kZXJlciB7XG4gIHByaXZhdGUgZXZlbnREZWxlZ2F0b3I6IEV2ZW50RGVsZWdhdG9yO1xuICBwcml2YXRlIGNoaWxkQ29tcG9uZW50TG9jYXRpb25zOiB7IFtjb21wb25lbnRJZDogbnVtYmVyXTogTG9naWNhbEVsZW1lbnQgfSA9IHt9O1xuXG4gIGNvbnN0cnVjdG9yKHByaXZhdGUgYnJvd3NlclJlbmRlcmVySWQ6IG51bWJlcikge1xuICAgIHRoaXMuZXZlbnREZWxlZ2F0b3IgPSBuZXcgRXZlbnREZWxlZ2F0b3IoKGV2ZW50LCBldmVudEhhbmRsZXJJZCwgZXZlbnRBcmdzKSA9PiB7XG4gICAgICByYWlzZUV2ZW50KGV2ZW50LCB0aGlzLmJyb3dzZXJSZW5kZXJlcklkLCBldmVudEhhbmRsZXJJZCwgZXZlbnRBcmdzKTtcbiAgICB9KTtcbiAgfVxuXG4gIHB1YmxpYyBhdHRhY2hSb290Q29tcG9uZW50VG9FbGVtZW50KGNvbXBvbmVudElkOiBudW1iZXIsIGVsZW1lbnQ6IEVsZW1lbnQpIHtcbiAgICAvLyAnYWxsb3dFeGlzdGluZ0NvbnRlbnRzJyB0byBrZWVwIGFueSBwcmVyZW5kZXJlZCBjb250ZW50IHVudGlsIHdlIGRvIHRoZSBmaXJzdCBjbGllbnQtc2lkZSByZW5kZXJcbiAgICB0aGlzLmF0dGFjaENvbXBvbmVudFRvRWxlbWVudChjb21wb25lbnRJZCwgdG9Mb2dpY2FsRWxlbWVudChlbGVtZW50LCAvKiBhbGxvd0V4aXN0aW5nQ29udGVudHMgKi8gdHJ1ZSkpO1xuICAgIHJvb3RDb21wb25lbnRzUGVuZGluZ0ZpcnN0UmVuZGVyW2NvbXBvbmVudElkXSA9IGVsZW1lbnQ7XG4gIH1cblxuICBwdWJsaWMgdXBkYXRlQ29tcG9uZW50KGJhdGNoOiBSZW5kZXJCYXRjaCwgY29tcG9uZW50SWQ6IG51bWJlciwgZWRpdHM6IEFycmF5U2VnbWVudDxSZW5kZXJUcmVlRWRpdD4sIHJlZmVyZW5jZUZyYW1lczogQXJyYXlWYWx1ZXM8UmVuZGVyVHJlZUZyYW1lPikge1xuICAgIGNvbnN0IGVsZW1lbnQgPSB0aGlzLmNoaWxkQ29tcG9uZW50TG9jYXRpb25zW2NvbXBvbmVudElkXTtcbiAgICBpZiAoIWVsZW1lbnQpIHtcbiAgICAgIHRocm93IG5ldyBFcnJvcihgTm8gZWxlbWVudCBpcyBjdXJyZW50bHkgYXNzb2NpYXRlZCB3aXRoIGNvbXBvbmVudCAke2NvbXBvbmVudElkfWApO1xuICAgIH1cblxuICAgIC8vIE9uIHRoZSBmaXJzdCByZW5kZXIgZm9yIGVhY2ggcm9vdCBjb21wb25lbnQsIGNsZWFyIGFueSBleGlzdGluZyBjb250ZW50IChlLmcuLCBwcmVyZW5kZXJlZClcbiAgICBjb25zdCByb290RWxlbWVudFRvQ2xlYXIgPSByb290Q29tcG9uZW50c1BlbmRpbmdGaXJzdFJlbmRlcltjb21wb25lbnRJZF07XG4gICAgaWYgKHJvb3RFbGVtZW50VG9DbGVhcikge1xuICAgICAgZGVsZXRlIHJvb3RDb21wb25lbnRzUGVuZGluZ0ZpcnN0UmVuZGVyW2NvbXBvbmVudElkXTtcbiAgICAgIGNsZWFyRWxlbWVudChyb290RWxlbWVudFRvQ2xlYXIpO1xuICAgIH1cblxuICAgIHRoaXMuYXBwbHlFZGl0cyhiYXRjaCwgZWxlbWVudCwgMCwgZWRpdHMsIHJlZmVyZW5jZUZyYW1lcyk7XG4gIH1cblxuICBwdWJsaWMgZGlzcG9zZUNvbXBvbmVudChjb21wb25lbnRJZDogbnVtYmVyKSB7XG4gICAgZGVsZXRlIHRoaXMuY2hpbGRDb21wb25lbnRMb2NhdGlvbnNbY29tcG9uZW50SWRdO1xuICB9XG5cbiAgcHVibGljIGRpc3Bvc2VFdmVudEhhbmRsZXIoZXZlbnRIYW5kbGVySWQ6IG51bWJlcikge1xuICAgIHRoaXMuZXZlbnREZWxlZ2F0b3IucmVtb3ZlTGlzdGVuZXIoZXZlbnRIYW5kbGVySWQpO1xuICB9XG5cbiAgcHJpdmF0ZSBhdHRhY2hDb21wb25lbnRUb0VsZW1lbnQoY29tcG9uZW50SWQ6IG51bWJlciwgZWxlbWVudDogTG9naWNhbEVsZW1lbnQpIHtcbiAgICB0aGlzLmNoaWxkQ29tcG9uZW50TG9jYXRpb25zW2NvbXBvbmVudElkXSA9IGVsZW1lbnQ7XG4gIH1cblxuICBwcml2YXRlIGFwcGx5RWRpdHMoYmF0Y2g6IFJlbmRlckJhdGNoLCBwYXJlbnQ6IExvZ2ljYWxFbGVtZW50LCBjaGlsZEluZGV4OiBudW1iZXIsIGVkaXRzOiBBcnJheVNlZ21lbnQ8UmVuZGVyVHJlZUVkaXQ+LCByZWZlcmVuY2VGcmFtZXM6IEFycmF5VmFsdWVzPFJlbmRlclRyZWVGcmFtZT4pIHtcbiAgICBsZXQgY3VycmVudERlcHRoID0gMDtcbiAgICBsZXQgY2hpbGRJbmRleEF0Q3VycmVudERlcHRoID0gY2hpbGRJbmRleDtcblxuICAgIGNvbnN0IGFycmF5U2VnbWVudFJlYWRlciA9IGJhdGNoLmFycmF5U2VnbWVudFJlYWRlcjtcbiAgICBjb25zdCBlZGl0UmVhZGVyID0gYmF0Y2guZWRpdFJlYWRlcjtcbiAgICBjb25zdCBmcmFtZVJlYWRlciA9IGJhdGNoLmZyYW1lUmVhZGVyO1xuICAgIGNvbnN0IGVkaXRzVmFsdWVzID0gYXJyYXlTZWdtZW50UmVhZGVyLnZhbHVlcyhlZGl0cyk7XG4gICAgY29uc3QgZWRpdHNPZmZzZXQgPSBhcnJheVNlZ21lbnRSZWFkZXIub2Zmc2V0KGVkaXRzKTtcbiAgICBjb25zdCBlZGl0c0xlbmd0aCA9IGFycmF5U2VnbWVudFJlYWRlci5jb3VudChlZGl0cyk7XG4gICAgY29uc3QgbWF4RWRpdEluZGV4RXhjbCA9IGVkaXRzT2Zmc2V0ICsgZWRpdHNMZW5ndGg7XG5cbiAgICBmb3IgKGxldCBlZGl0SW5kZXggPSBlZGl0c09mZnNldDsgZWRpdEluZGV4IDwgbWF4RWRpdEluZGV4RXhjbDsgZWRpdEluZGV4KyspIHtcbiAgICAgIGNvbnN0IGVkaXQgPSBiYXRjaC5kaWZmUmVhZGVyLmVkaXRzRW50cnkoZWRpdHNWYWx1ZXMsIGVkaXRJbmRleCk7XG4gICAgICBjb25zdCBlZGl0VHlwZSA9IGVkaXRSZWFkZXIuZWRpdFR5cGUoZWRpdCk7XG4gICAgICBzd2l0Y2ggKGVkaXRUeXBlKSB7XG4gICAgICAgIGNhc2UgRWRpdFR5cGUucHJlcGVuZEZyYW1lOiB7XG4gICAgICAgICAgY29uc3QgZnJhbWVJbmRleCA9IGVkaXRSZWFkZXIubmV3VHJlZUluZGV4KGVkaXQpO1xuICAgICAgICAgIGNvbnN0IGZyYW1lID0gYmF0Y2gucmVmZXJlbmNlRnJhbWVzRW50cnkocmVmZXJlbmNlRnJhbWVzLCBmcmFtZUluZGV4KTtcbiAgICAgICAgICBjb25zdCBzaWJsaW5nSW5kZXggPSBlZGl0UmVhZGVyLnNpYmxpbmdJbmRleChlZGl0KTtcbiAgICAgICAgICB0aGlzLmluc2VydEZyYW1lKGJhdGNoLCBwYXJlbnQsIGNoaWxkSW5kZXhBdEN1cnJlbnREZXB0aCArIHNpYmxpbmdJbmRleCwgcmVmZXJlbmNlRnJhbWVzLCBmcmFtZSwgZnJhbWVJbmRleCk7XG4gICAgICAgICAgYnJlYWs7XG4gICAgICAgIH1cbiAgICAgICAgY2FzZSBFZGl0VHlwZS5yZW1vdmVGcmFtZToge1xuICAgICAgICAgIGNvbnN0IHNpYmxpbmdJbmRleCA9IGVkaXRSZWFkZXIuc2libGluZ0luZGV4KGVkaXQpO1xuICAgICAgICAgIHJlbW92ZUxvZ2ljYWxDaGlsZChwYXJlbnQsIGNoaWxkSW5kZXhBdEN1cnJlbnREZXB0aCArIHNpYmxpbmdJbmRleCk7XG4gICAgICAgICAgYnJlYWs7XG4gICAgICAgIH1cbiAgICAgICAgY2FzZSBFZGl0VHlwZS5zZXRBdHRyaWJ1dGU6IHtcbiAgICAgICAgICBjb25zdCBmcmFtZUluZGV4ID0gZWRpdFJlYWRlci5uZXdUcmVlSW5kZXgoZWRpdCk7XG4gICAgICAgICAgY29uc3QgZnJhbWUgPSBiYXRjaC5yZWZlcmVuY2VGcmFtZXNFbnRyeShyZWZlcmVuY2VGcmFtZXMsIGZyYW1lSW5kZXgpO1xuICAgICAgICAgIGNvbnN0IHNpYmxpbmdJbmRleCA9IGVkaXRSZWFkZXIuc2libGluZ0luZGV4KGVkaXQpO1xuICAgICAgICAgIGNvbnN0IGVsZW1lbnQgPSBnZXRMb2dpY2FsQ2hpbGQocGFyZW50LCBjaGlsZEluZGV4QXRDdXJyZW50RGVwdGggKyBzaWJsaW5nSW5kZXgpO1xuICAgICAgICAgIGlmIChlbGVtZW50IGluc3RhbmNlb2YgRWxlbWVudCkge1xuICAgICAgICAgICAgdGhpcy5hcHBseUF0dHJpYnV0ZShiYXRjaCwgZWxlbWVudCwgZnJhbWUpO1xuICAgICAgICAgIH0gZWxzZSB7XG4gICAgICAgICAgICB0aHJvdyBuZXcgRXJyb3IoYENhbm5vdCBzZXQgYXR0cmlidXRlIG9uIG5vbi1lbGVtZW50IGNoaWxkYCk7XG4gICAgICAgICAgfVxuICAgICAgICAgIGJyZWFrO1xuICAgICAgICB9XG4gICAgICAgIGNhc2UgRWRpdFR5cGUucmVtb3ZlQXR0cmlidXRlOiB7XG4gICAgICAgICAgLy8gTm90ZSB0aGF0IHdlIGRvbid0IGhhdmUgdG8gZGlzcG9zZSB0aGUgaW5mbyB3ZSB0cmFjayBhYm91dCBldmVudCBoYW5kbGVycyBoZXJlLCBiZWNhdXNlIHRoZVxuICAgICAgICAgIC8vIGRpc3Bvc2VkIGV2ZW50IGhhbmRsZXIgSURzIGFyZSBkZWxpdmVyZWQgc2VwYXJhdGVseSAoaW4gdGhlICdkaXNwb3NlZEV2ZW50SGFuZGxlcklkcycgYXJyYXkpXG4gICAgICAgICAgY29uc3Qgc2libGluZ0luZGV4ID0gZWRpdFJlYWRlci5zaWJsaW5nSW5kZXgoZWRpdCk7XG4gICAgICAgICAgY29uc3QgZWxlbWVudCA9IGdldExvZ2ljYWxDaGlsZChwYXJlbnQsIGNoaWxkSW5kZXhBdEN1cnJlbnREZXB0aCArIHNpYmxpbmdJbmRleCk7XG4gICAgICAgICAgaWYgKGVsZW1lbnQgaW5zdGFuY2VvZiBIVE1MRWxlbWVudCkge1xuICAgICAgICAgICAgY29uc3QgYXR0cmlidXRlTmFtZSA9IGVkaXRSZWFkZXIucmVtb3ZlZEF0dHJpYnV0ZU5hbWUoZWRpdCkhO1xuICAgICAgICAgICAgLy8gRmlyc3QgdHJ5IHRvIHJlbW92ZSBhbnkgc3BlY2lhbCBwcm9wZXJ0eSB3ZSB1c2UgZm9yIHRoaXMgYXR0cmlidXRlXG4gICAgICAgICAgICBpZiAoIXRoaXMudHJ5QXBwbHlTcGVjaWFsUHJvcGVydHkoYmF0Y2gsIGVsZW1lbnQsIGF0dHJpYnV0ZU5hbWUsIG51bGwpKSB7XG4gICAgICAgICAgICAgIC8vIElmIHRoYXQncyBub3QgYXBwbGljYWJsZSwgaXQncyBhIHJlZ3VsYXIgRE9NIGF0dHJpYnV0ZSBzbyByZW1vdmUgdGhhdFxuICAgICAgICAgICAgICBlbGVtZW50LnJlbW92ZUF0dHJpYnV0ZShhdHRyaWJ1dGVOYW1lKTtcbiAgICAgICAgICAgIH1cbiAgICAgICAgICB9IGVsc2Uge1xuICAgICAgICAgICAgdGhyb3cgbmV3IEVycm9yKGBDYW5ub3QgcmVtb3ZlIGF0dHJpYnV0ZSBmcm9tIG5vbi1lbGVtZW50IGNoaWxkYCk7XG4gICAgICAgICAgfVxuICAgICAgICAgIGJyZWFrO1xuICAgICAgICB9XG4gICAgICAgIGNhc2UgRWRpdFR5cGUudXBkYXRlVGV4dDoge1xuICAgICAgICAgIGNvbnN0IGZyYW1lSW5kZXggPSBlZGl0UmVhZGVyLm5ld1RyZWVJbmRleChlZGl0KTtcbiAgICAgICAgICBjb25zdCBmcmFtZSA9IGJhdGNoLnJlZmVyZW5jZUZyYW1lc0VudHJ5KHJlZmVyZW5jZUZyYW1lcywgZnJhbWVJbmRleCk7XG4gICAgICAgICAgY29uc3Qgc2libGluZ0luZGV4ID0gZWRpdFJlYWRlci5zaWJsaW5nSW5kZXgoZWRpdCk7XG4gICAgICAgICAgY29uc3QgdGV4dE5vZGUgPSBnZXRMb2dpY2FsQ2hpbGQocGFyZW50LCBjaGlsZEluZGV4QXRDdXJyZW50RGVwdGggKyBzaWJsaW5nSW5kZXgpO1xuICAgICAgICAgIGlmICh0ZXh0Tm9kZSBpbnN0YW5jZW9mIFRleHQpIHtcbiAgICAgICAgICAgIHRleHROb2RlLnRleHRDb250ZW50ID0gZnJhbWVSZWFkZXIudGV4dENvbnRlbnQoZnJhbWUpO1xuICAgICAgICAgIH0gZWxzZSB7XG4gICAgICAgICAgICB0aHJvdyBuZXcgRXJyb3IoYENhbm5vdCBzZXQgdGV4dCBjb250ZW50IG9uIG5vbi10ZXh0IGNoaWxkYCk7XG4gICAgICAgICAgfVxuICAgICAgICAgIGJyZWFrO1xuICAgICAgICB9XG4gICAgICAgIGNhc2UgRWRpdFR5cGUudXBkYXRlTWFya3VwOiB7XG4gICAgICAgICAgY29uc3QgZnJhbWVJbmRleCA9IGVkaXRSZWFkZXIubmV3VHJlZUluZGV4KGVkaXQpO1xuICAgICAgICAgIGNvbnN0IGZyYW1lID0gYmF0Y2gucmVmZXJlbmNlRnJhbWVzRW50cnkocmVmZXJlbmNlRnJhbWVzLCBmcmFtZUluZGV4KTtcbiAgICAgICAgICBjb25zdCBzaWJsaW5nSW5kZXggPSBlZGl0UmVhZGVyLnNpYmxpbmdJbmRleChlZGl0KTtcbiAgICAgICAgICByZW1vdmVMb2dpY2FsQ2hpbGQocGFyZW50LCBjaGlsZEluZGV4QXRDdXJyZW50RGVwdGggKyBzaWJsaW5nSW5kZXgpO1xuICAgICAgICAgIHRoaXMuaW5zZXJ0TWFya3VwKGJhdGNoLCBwYXJlbnQsIGNoaWxkSW5kZXhBdEN1cnJlbnREZXB0aCArIHNpYmxpbmdJbmRleCwgZnJhbWUpO1xuICAgICAgICAgIGJyZWFrO1xuICAgICAgICB9XG4gICAgICAgIGNhc2UgRWRpdFR5cGUuc3RlcEluOiB7XG4gICAgICAgICAgY29uc3Qgc2libGluZ0luZGV4ID0gZWRpdFJlYWRlci5zaWJsaW5nSW5kZXgoZWRpdCk7XG4gICAgICAgICAgcGFyZW50ID0gZ2V0TG9naWNhbENoaWxkKHBhcmVudCwgY2hpbGRJbmRleEF0Q3VycmVudERlcHRoICsgc2libGluZ0luZGV4KTtcbiAgICAgICAgICBjdXJyZW50RGVwdGgrKztcbiAgICAgICAgICBjaGlsZEluZGV4QXRDdXJyZW50RGVwdGggPSAwO1xuICAgICAgICAgIGJyZWFrO1xuICAgICAgICB9XG4gICAgICAgIGNhc2UgRWRpdFR5cGUuc3RlcE91dDoge1xuICAgICAgICAgIHBhcmVudCA9IGdldExvZ2ljYWxQYXJlbnQocGFyZW50KSE7XG4gICAgICAgICAgY3VycmVudERlcHRoLS07XG4gICAgICAgICAgY2hpbGRJbmRleEF0Q3VycmVudERlcHRoID0gY3VycmVudERlcHRoID09PSAwID8gY2hpbGRJbmRleCA6IDA7IC8vIFRoZSBjaGlsZEluZGV4IGlzIG9ubHkgZXZlciBub256ZXJvIGF0IHplcm8gZGVwdGhcbiAgICAgICAgICBicmVhaztcbiAgICAgICAgfVxuICAgICAgICBkZWZhdWx0OiB7XG4gICAgICAgICAgY29uc3QgdW5rbm93blR5cGU6IG5ldmVyID0gZWRpdFR5cGU7IC8vIENvbXBpbGUtdGltZSB2ZXJpZmljYXRpb24gdGhhdCB0aGUgc3dpdGNoIHdhcyBleGhhdXN0aXZlXG4gICAgICAgICAgdGhyb3cgbmV3IEVycm9yKGBVbmtub3duIGVkaXQgdHlwZTogJHt1bmtub3duVHlwZX1gKTtcbiAgICAgICAgfVxuICAgICAgfVxuICAgIH1cbiAgfVxuXG4gIHByaXZhdGUgaW5zZXJ0RnJhbWUoYmF0Y2g6IFJlbmRlckJhdGNoLCBwYXJlbnQ6IExvZ2ljYWxFbGVtZW50LCBjaGlsZEluZGV4OiBudW1iZXIsIGZyYW1lczogQXJyYXlWYWx1ZXM8UmVuZGVyVHJlZUZyYW1lPiwgZnJhbWU6IFJlbmRlclRyZWVGcmFtZSwgZnJhbWVJbmRleDogbnVtYmVyKTogbnVtYmVyIHtcbiAgICBjb25zdCBmcmFtZVJlYWRlciA9IGJhdGNoLmZyYW1lUmVhZGVyO1xuICAgIGNvbnN0IGZyYW1lVHlwZSA9IGZyYW1lUmVhZGVyLmZyYW1lVHlwZShmcmFtZSk7XG4gICAgc3dpdGNoIChmcmFtZVR5cGUpIHtcbiAgICAgIGNhc2UgRnJhbWVUeXBlLmVsZW1lbnQ6XG4gICAgICAgIHRoaXMuaW5zZXJ0RWxlbWVudChiYXRjaCwgcGFyZW50LCBjaGlsZEluZGV4LCBmcmFtZXMsIGZyYW1lLCBmcmFtZUluZGV4KTtcbiAgICAgICAgcmV0dXJuIDE7XG4gICAgICBjYXNlIEZyYW1lVHlwZS50ZXh0OlxuICAgICAgICB0aGlzLmluc2VydFRleHQoYmF0Y2gsIHBhcmVudCwgY2hpbGRJbmRleCwgZnJhbWUpO1xuICAgICAgICByZXR1cm4gMTtcbiAgICAgIGNhc2UgRnJhbWVUeXBlLmF0dHJpYnV0ZTpcbiAgICAgICAgdGhyb3cgbmV3IEVycm9yKCdBdHRyaWJ1dGUgZnJhbWVzIHNob3VsZCBvbmx5IGJlIHByZXNlbnQgYXMgbGVhZGluZyBjaGlsZHJlbiBvZiBlbGVtZW50IGZyYW1lcy4nKTtcbiAgICAgIGNhc2UgRnJhbWVUeXBlLmNvbXBvbmVudDpcbiAgICAgICAgdGhpcy5pbnNlcnRDb21wb25lbnQoYmF0Y2gsIHBhcmVudCwgY2hpbGRJbmRleCwgZnJhbWUpO1xuICAgICAgICByZXR1cm4gMTtcbiAgICAgIGNhc2UgRnJhbWVUeXBlLnJlZ2lvbjpcbiAgICAgICAgcmV0dXJuIHRoaXMuaW5zZXJ0RnJhbWVSYW5nZShiYXRjaCwgcGFyZW50LCBjaGlsZEluZGV4LCBmcmFtZXMsIGZyYW1lSW5kZXggKyAxLCBmcmFtZUluZGV4ICsgZnJhbWVSZWFkZXIuc3VidHJlZUxlbmd0aChmcmFtZSkpO1xuICAgICAgY2FzZSBGcmFtZVR5cGUuZWxlbWVudFJlZmVyZW5jZUNhcHR1cmU6XG4gICAgICAgIGlmIChwYXJlbnQgaW5zdGFuY2VvZiBFbGVtZW50KSB7XG4gICAgICAgICAgYXBwbHlDYXB0dXJlSWRUb0VsZW1lbnQocGFyZW50LCBmcmFtZVJlYWRlci5lbGVtZW50UmVmZXJlbmNlQ2FwdHVyZUlkKGZyYW1lKSEpO1xuICAgICAgICAgIHJldHVybiAwOyAvLyBBIFwiY2FwdHVyZVwiIGlzIGEgY2hpbGQgaW4gdGhlIGRpZmYsIGJ1dCBoYXMgbm8gbm9kZSBpbiB0aGUgRE9NXG4gICAgICAgIH0gZWxzZSB7XG4gICAgICAgICAgdGhyb3cgbmV3IEVycm9yKCdSZWZlcmVuY2UgY2FwdHVyZSBmcmFtZXMgY2FuIG9ubHkgYmUgY2hpbGRyZW4gb2YgZWxlbWVudCBmcmFtZXMuJyk7XG4gICAgICAgIH1cbiAgICAgIGNhc2UgRnJhbWVUeXBlLm1hcmt1cDpcbiAgICAgICAgdGhpcy5pbnNlcnRNYXJrdXAoYmF0Y2gsIHBhcmVudCwgY2hpbGRJbmRleCwgZnJhbWUpO1xuICAgICAgICByZXR1cm4gMTtcbiAgICAgIGRlZmF1bHQ6XG4gICAgICAgIGNvbnN0IHVua25vd25UeXBlOiBuZXZlciA9IGZyYW1lVHlwZTsgLy8gQ29tcGlsZS10aW1lIHZlcmlmaWNhdGlvbiB0aGF0IHRoZSBzd2l0Y2ggd2FzIGV4aGF1c3RpdmVcbiAgICAgICAgdGhyb3cgbmV3IEVycm9yKGBVbmtub3duIGZyYW1lIHR5cGU6ICR7dW5rbm93blR5cGV9YCk7XG4gICAgfVxuICB9XG5cbiAgcHJpdmF0ZSBpbnNlcnRFbGVtZW50KGJhdGNoOiBSZW5kZXJCYXRjaCwgcGFyZW50OiBMb2dpY2FsRWxlbWVudCwgY2hpbGRJbmRleDogbnVtYmVyLCBmcmFtZXM6IEFycmF5VmFsdWVzPFJlbmRlclRyZWVGcmFtZT4sIGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUsIGZyYW1lSW5kZXg6IG51bWJlcikge1xuICAgIGNvbnN0IGZyYW1lUmVhZGVyID0gYmF0Y2guZnJhbWVSZWFkZXI7XG4gICAgY29uc3QgdGFnTmFtZSA9IGZyYW1lUmVhZGVyLmVsZW1lbnROYW1lKGZyYW1lKSE7XG4gICAgY29uc3QgbmV3RG9tRWxlbWVudFJhdyA9IHRhZ05hbWUgPT09ICdzdmcnIHx8IGlzU3ZnRWxlbWVudChwYXJlbnQpID9cbiAgICAgIGRvY3VtZW50LmNyZWF0ZUVsZW1lbnROUygnaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmcnLCB0YWdOYW1lKSA6XG4gICAgICBkb2N1bWVudC5jcmVhdGVFbGVtZW50KHRhZ05hbWUpO1xuICAgIGNvbnN0IG5ld0VsZW1lbnQgPSB0b0xvZ2ljYWxFbGVtZW50KG5ld0RvbUVsZW1lbnRSYXcpO1xuICAgIGluc2VydExvZ2ljYWxDaGlsZChuZXdEb21FbGVtZW50UmF3LCBwYXJlbnQsIGNoaWxkSW5kZXgpO1xuXG4gICAgLy8gQXBwbHkgYXR0cmlidXRlc1xuICAgIGNvbnN0IGRlc2NlbmRhbnRzRW5kSW5kZXhFeGNsID0gZnJhbWVJbmRleCArIGZyYW1lUmVhZGVyLnN1YnRyZWVMZW5ndGgoZnJhbWUpO1xuICAgIGZvciAobGV0IGRlc2NlbmRhbnRJbmRleCA9IGZyYW1lSW5kZXggKyAxOyBkZXNjZW5kYW50SW5kZXggPCBkZXNjZW5kYW50c0VuZEluZGV4RXhjbDsgZGVzY2VuZGFudEluZGV4KyspIHtcbiAgICAgIGNvbnN0IGRlc2NlbmRhbnRGcmFtZSA9IGJhdGNoLnJlZmVyZW5jZUZyYW1lc0VudHJ5KGZyYW1lcywgZGVzY2VuZGFudEluZGV4KTtcbiAgICAgIGlmIChmcmFtZVJlYWRlci5mcmFtZVR5cGUoZGVzY2VuZGFudEZyYW1lKSA9PT0gRnJhbWVUeXBlLmF0dHJpYnV0ZSkge1xuICAgICAgICB0aGlzLmFwcGx5QXR0cmlidXRlKGJhdGNoLCBuZXdEb21FbGVtZW50UmF3LCBkZXNjZW5kYW50RnJhbWUpO1xuICAgICAgfSBlbHNlIHtcbiAgICAgICAgLy8gQXMgc29vbiBhcyB3ZSBzZWUgYSBub24tYXR0cmlidXRlIGNoaWxkLCBhbGwgdGhlIHN1YnNlcXVlbnQgY2hpbGQgZnJhbWVzIGFyZVxuICAgICAgICAvLyBub3QgYXR0cmlidXRlcywgc28gYmFpbCBvdXQgYW5kIGluc2VydCB0aGUgcmVtbmFudHMgcmVjdXJzaXZlbHlcbiAgICAgICAgdGhpcy5pbnNlcnRGcmFtZVJhbmdlKGJhdGNoLCBuZXdFbGVtZW50LCAwLCBmcmFtZXMsIGRlc2NlbmRhbnRJbmRleCwgZGVzY2VuZGFudHNFbmRJbmRleEV4Y2wpO1xuICAgICAgICBicmVhaztcbiAgICAgIH1cbiAgICB9XG4gIH1cblxuICBwcml2YXRlIGluc2VydENvbXBvbmVudChiYXRjaDogUmVuZGVyQmF0Y2gsIHBhcmVudDogTG9naWNhbEVsZW1lbnQsIGNoaWxkSW5kZXg6IG51bWJlciwgZnJhbWU6IFJlbmRlclRyZWVGcmFtZSkge1xuICAgIGNvbnN0IGNvbnRhaW5lckVsZW1lbnQgPSBjcmVhdGVBbmRJbnNlcnRMb2dpY2FsQ29udGFpbmVyKHBhcmVudCwgY2hpbGRJbmRleCk7XG5cbiAgICAvLyBBbGwgd2UgaGF2ZSB0byBkbyBpcyBhc3NvY2lhdGUgdGhlIGNoaWxkIGNvbXBvbmVudCBJRCB3aXRoIGl0cyBsb2NhdGlvbi4gV2UgZG9uJ3QgYWN0dWFsbHlcbiAgICAvLyBkbyBhbnkgcmVuZGVyaW5nIGhlcmUsIGJlY2F1c2UgdGhlIGRpZmYgZm9yIHRoZSBjaGlsZCB3aWxsIGFwcGVhciBsYXRlciBpbiB0aGUgcmVuZGVyIGJhdGNoLlxuICAgIGNvbnN0IGNoaWxkQ29tcG9uZW50SWQgPSBiYXRjaC5mcmFtZVJlYWRlci5jb21wb25lbnRJZChmcmFtZSk7XG4gICAgdGhpcy5hdHRhY2hDb21wb25lbnRUb0VsZW1lbnQoY2hpbGRDb21wb25lbnRJZCwgY29udGFpbmVyRWxlbWVudCk7XG4gIH1cblxuICBwcml2YXRlIGluc2VydFRleHQoYmF0Y2g6IFJlbmRlckJhdGNoLCBwYXJlbnQ6IExvZ2ljYWxFbGVtZW50LCBjaGlsZEluZGV4OiBudW1iZXIsIHRleHRGcmFtZTogUmVuZGVyVHJlZUZyYW1lKSB7XG4gICAgY29uc3QgdGV4dENvbnRlbnQgPSBiYXRjaC5mcmFtZVJlYWRlci50ZXh0Q29udGVudCh0ZXh0RnJhbWUpITtcbiAgICBjb25zdCBuZXdUZXh0Tm9kZSA9IGRvY3VtZW50LmNyZWF0ZVRleHROb2RlKHRleHRDb250ZW50KTtcbiAgICBpbnNlcnRMb2dpY2FsQ2hpbGQobmV3VGV4dE5vZGUsIHBhcmVudCwgY2hpbGRJbmRleCk7XG4gIH1cblxuICBwcml2YXRlIGluc2VydE1hcmt1cChiYXRjaDogUmVuZGVyQmF0Y2gsIHBhcmVudDogTG9naWNhbEVsZW1lbnQsIGNoaWxkSW5kZXg6IG51bWJlciwgbWFya3VwRnJhbWU6IFJlbmRlclRyZWVGcmFtZSkge1xuICAgIGNvbnN0IG1hcmt1cENvbnRhaW5lciA9IGNyZWF0ZUFuZEluc2VydExvZ2ljYWxDb250YWluZXIocGFyZW50LCBjaGlsZEluZGV4KTtcblxuICAgIGNvbnN0IG1hcmt1cENvbnRlbnQgPSBiYXRjaC5mcmFtZVJlYWRlci5tYXJrdXBDb250ZW50KG1hcmt1cEZyYW1lKTtcbiAgICBjb25zdCBwYXJzZWRNYXJrdXAgPSBwYXJzZU1hcmt1cChtYXJrdXBDb250ZW50LCBpc1N2Z0VsZW1lbnQocGFyZW50KSk7XG4gICAgbGV0IGxvZ2ljYWxTaWJsaW5nSW5kZXggPSAwO1xuICAgIHdoaWxlIChwYXJzZWRNYXJrdXAuZmlyc3RDaGlsZCkge1xuICAgICAgaW5zZXJ0TG9naWNhbENoaWxkKHBhcnNlZE1hcmt1cC5maXJzdENoaWxkLCBtYXJrdXBDb250YWluZXIsIGxvZ2ljYWxTaWJsaW5nSW5kZXgrKyk7XG4gICAgfVxuICB9XG5cbiAgcHJpdmF0ZSBhcHBseUF0dHJpYnV0ZShiYXRjaDogUmVuZGVyQmF0Y2gsIHRvRG9tRWxlbWVudDogRWxlbWVudCwgYXR0cmlidXRlRnJhbWU6IFJlbmRlclRyZWVGcmFtZSkge1xuICAgIGNvbnN0IGZyYW1lUmVhZGVyID0gYmF0Y2guZnJhbWVSZWFkZXI7XG4gICAgY29uc3QgYXR0cmlidXRlTmFtZSA9IGZyYW1lUmVhZGVyLmF0dHJpYnV0ZU5hbWUoYXR0cmlidXRlRnJhbWUpITtcbiAgICBjb25zdCBicm93c2VyUmVuZGVyZXJJZCA9IHRoaXMuYnJvd3NlclJlbmRlcmVySWQ7XG4gICAgY29uc3QgZXZlbnRIYW5kbGVySWQgPSBmcmFtZVJlYWRlci5hdHRyaWJ1dGVFdmVudEhhbmRsZXJJZChhdHRyaWJ1dGVGcmFtZSk7XG5cbiAgICBpZiAoZXZlbnRIYW5kbGVySWQpIHtcbiAgICAgIGNvbnN0IGZpcnN0VHdvQ2hhcnMgPSBhdHRyaWJ1dGVOYW1lLnN1YnN0cmluZygwLCAyKTtcbiAgICAgIGNvbnN0IGV2ZW50TmFtZSA9IGF0dHJpYnV0ZU5hbWUuc3Vic3RyaW5nKDIpO1xuICAgICAgaWYgKGZpcnN0VHdvQ2hhcnMgIT09ICdvbicgfHwgIWV2ZW50TmFtZSkge1xuICAgICAgICB0aHJvdyBuZXcgRXJyb3IoYEF0dHJpYnV0ZSBoYXMgbm9uemVybyBldmVudCBoYW5kbGVyIElELCBidXQgYXR0cmlidXRlIG5hbWUgJyR7YXR0cmlidXRlTmFtZX0nIGRvZXMgbm90IHN0YXJ0IHdpdGggJ29uJy5gKTtcbiAgICAgIH1cbiAgICAgIHRoaXMuZXZlbnREZWxlZ2F0b3Iuc2V0TGlzdGVuZXIodG9Eb21FbGVtZW50LCBldmVudE5hbWUsIGV2ZW50SGFuZGxlcklkKTtcbiAgICAgIHJldHVybjtcbiAgICB9XG5cbiAgICAvLyBGaXJzdCBzZWUgaWYgd2UgaGF2ZSBzcGVjaWFsIGhhbmRsaW5nIGZvciB0aGlzIGF0dHJpYnV0ZVxuICAgIGlmICghdGhpcy50cnlBcHBseVNwZWNpYWxQcm9wZXJ0eShiYXRjaCwgdG9Eb21FbGVtZW50LCBhdHRyaWJ1dGVOYW1lLCBhdHRyaWJ1dGVGcmFtZSkpIHtcbiAgICAgIC8vIElmIG5vdCwgdHJlYXQgaXQgYXMgYSByZWd1bGFyIHN0cmluZy12YWx1ZWQgYXR0cmlidXRlXG4gICAgICB0b0RvbUVsZW1lbnQuc2V0QXR0cmlidXRlKFxuICAgICAgICBhdHRyaWJ1dGVOYW1lLFxuICAgICAgICBmcmFtZVJlYWRlci5hdHRyaWJ1dGVWYWx1ZShhdHRyaWJ1dGVGcmFtZSkhXG4gICAgICApO1xuICAgIH1cbiAgfVxuXG4gIHByaXZhdGUgdHJ5QXBwbHlTcGVjaWFsUHJvcGVydHkoYmF0Y2g6IFJlbmRlckJhdGNoLCBlbGVtZW50OiBFbGVtZW50LCBhdHRyaWJ1dGVOYW1lOiBzdHJpbmcsIGF0dHJpYnV0ZUZyYW1lOiBSZW5kZXJUcmVlRnJhbWUgfCBudWxsKSB7XG4gICAgc3dpdGNoIChhdHRyaWJ1dGVOYW1lKSB7XG4gICAgICBjYXNlICd2YWx1ZSc6XG4gICAgICAgIHJldHVybiB0aGlzLnRyeUFwcGx5VmFsdWVQcm9wZXJ0eShiYXRjaCwgZWxlbWVudCwgYXR0cmlidXRlRnJhbWUpO1xuICAgICAgY2FzZSAnY2hlY2tlZCc6XG4gICAgICAgIHJldHVybiB0aGlzLnRyeUFwcGx5Q2hlY2tlZFByb3BlcnR5KGJhdGNoLCBlbGVtZW50LCBhdHRyaWJ1dGVGcmFtZSk7XG4gICAgICBkZWZhdWx0OlxuICAgICAgICByZXR1cm4gZmFsc2U7XG4gICAgfVxuICB9XG5cbiAgcHJpdmF0ZSB0cnlBcHBseVZhbHVlUHJvcGVydHkoYmF0Y2g6IFJlbmRlckJhdGNoLCBlbGVtZW50OiBFbGVtZW50LCBhdHRyaWJ1dGVGcmFtZTogUmVuZGVyVHJlZUZyYW1lIHwgbnVsbCkge1xuICAgIC8vIENlcnRhaW4gZWxlbWVudHMgaGF2ZSBidWlsdC1pbiBiZWhhdmlvdXIgZm9yIHRoZWlyICd2YWx1ZScgcHJvcGVydHlcbiAgICBjb25zdCBmcmFtZVJlYWRlciA9IGJhdGNoLmZyYW1lUmVhZGVyO1xuICAgIHN3aXRjaCAoZWxlbWVudC50YWdOYW1lKSB7XG4gICAgICBjYXNlICdJTlBVVCc6XG4gICAgICBjYXNlICdTRUxFQ1QnOlxuICAgICAgY2FzZSAnVEVYVEFSRUEnOiB7XG4gICAgICAgIGNvbnN0IHZhbHVlID0gYXR0cmlidXRlRnJhbWUgPyBmcmFtZVJlYWRlci5hdHRyaWJ1dGVWYWx1ZShhdHRyaWJ1dGVGcmFtZSkgOiBudWxsO1xuICAgICAgICAoZWxlbWVudCBhcyBhbnkpLnZhbHVlID0gdmFsdWU7XG5cbiAgICAgICAgaWYgKGVsZW1lbnQudGFnTmFtZSA9PT0gJ1NFTEVDVCcpIHtcbiAgICAgICAgICAvLyA8c2VsZWN0PiBpcyBzcGVjaWFsLCBpbiB0aGF0IGFueXRoaW5nIHdlIHdyaXRlIHRvIC52YWx1ZSB3aWxsIGJlIGxvc3QgaWYgdGhlcmVcbiAgICAgICAgICAvLyBpc24ndCB5ZXQgYSBtYXRjaGluZyA8b3B0aW9uPi4gVG8gbWFpbnRhaW4gdGhlIGV4cGVjdGVkIGJlaGF2aW9yIG5vIG1hdHRlciB0aGVcbiAgICAgICAgICAvLyBlbGVtZW50IGluc2VydGlvbi91cGRhdGUgb3JkZXIsIHByZXNlcnZlIHRoZSBkZXNpcmVkIHZhbHVlIHNlcGFyYXRlbHkgc29cbiAgICAgICAgICAvLyB3ZSBjYW4gcmVjb3ZlciBpdCB3aGVuIGluc2VydGluZyBhbnkgbWF0Y2hpbmcgPG9wdGlvbj4uXG4gICAgICAgICAgZWxlbWVudFtzZWxlY3RWYWx1ZVByb3BuYW1lXSA9IHZhbHVlO1xuICAgICAgICB9XG4gICAgICAgIHJldHVybiB0cnVlO1xuICAgICAgfVxuICAgICAgY2FzZSAnT1BUSU9OJzoge1xuICAgICAgICBjb25zdCB2YWx1ZSA9IGF0dHJpYnV0ZUZyYW1lID8gZnJhbWVSZWFkZXIuYXR0cmlidXRlVmFsdWUoYXR0cmlidXRlRnJhbWUpIDogbnVsbDtcbiAgICAgICAgaWYgKHZhbHVlKSB7XG4gICAgICAgICAgZWxlbWVudC5zZXRBdHRyaWJ1dGUoJ3ZhbHVlJywgdmFsdWUpO1xuICAgICAgICB9IGVsc2Uge1xuICAgICAgICAgIGVsZW1lbnQucmVtb3ZlQXR0cmlidXRlKCd2YWx1ZScpO1xuICAgICAgICB9XG4gICAgICAgIC8vIFNlZSBhYm92ZSBmb3Igd2h5IHdlIGhhdmUgdGhpcyBzcGVjaWFsIGhhbmRsaW5nIGZvciA8c2VsZWN0Pi88b3B0aW9uPlxuICAgICAgICBjb25zdCBwYXJlbnRFbGVtZW50ID0gZWxlbWVudC5wYXJlbnRFbGVtZW50O1xuICAgICAgICBpZiAocGFyZW50RWxlbWVudCAmJiAoc2VsZWN0VmFsdWVQcm9wbmFtZSBpbiBwYXJlbnRFbGVtZW50KSAmJiBwYXJlbnRFbGVtZW50W3NlbGVjdFZhbHVlUHJvcG5hbWVdID09PSB2YWx1ZSkge1xuICAgICAgICAgIHRoaXMudHJ5QXBwbHlWYWx1ZVByb3BlcnR5KGJhdGNoLCBwYXJlbnRFbGVtZW50LCBhdHRyaWJ1dGVGcmFtZSk7XG4gICAgICAgICAgZGVsZXRlIHBhcmVudEVsZW1lbnRbc2VsZWN0VmFsdWVQcm9wbmFtZV07XG4gICAgICAgIH1cbiAgICAgICAgcmV0dXJuIHRydWU7XG4gICAgICB9XG4gICAgICBkZWZhdWx0OlxuICAgICAgICByZXR1cm4gZmFsc2U7XG4gICAgfVxuICB9XG5cbiAgcHJpdmF0ZSB0cnlBcHBseUNoZWNrZWRQcm9wZXJ0eShiYXRjaDogUmVuZGVyQmF0Y2gsIGVsZW1lbnQ6IEVsZW1lbnQsIGF0dHJpYnV0ZUZyYW1lOiBSZW5kZXJUcmVlRnJhbWUgfCBudWxsKSB7XG4gICAgLy8gQ2VydGFpbiBlbGVtZW50cyBoYXZlIGJ1aWx0LWluIGJlaGF2aW91ciBmb3IgdGhlaXIgJ2NoZWNrZWQnIHByb3BlcnR5XG4gICAgaWYgKGVsZW1lbnQudGFnTmFtZSA9PT0gJ0lOUFVUJykge1xuICAgICAgY29uc3QgdmFsdWUgPSBhdHRyaWJ1dGVGcmFtZSA/IGJhdGNoLmZyYW1lUmVhZGVyLmF0dHJpYnV0ZVZhbHVlKGF0dHJpYnV0ZUZyYW1lKSA6IG51bGw7XG4gICAgICAoZWxlbWVudCBhcyBhbnkpLmNoZWNrZWQgPSB2YWx1ZSAhPT0gbnVsbDtcbiAgICAgIHJldHVybiB0cnVlO1xuICAgIH0gZWxzZSB7XG4gICAgICByZXR1cm4gZmFsc2U7XG4gICAgfVxuICB9XG5cbiAgcHJpdmF0ZSBpbnNlcnRGcmFtZVJhbmdlKGJhdGNoOiBSZW5kZXJCYXRjaCwgcGFyZW50OiBMb2dpY2FsRWxlbWVudCwgY2hpbGRJbmRleDogbnVtYmVyLCBmcmFtZXM6IEFycmF5VmFsdWVzPFJlbmRlclRyZWVGcmFtZT4sIHN0YXJ0SW5kZXg6IG51bWJlciwgZW5kSW5kZXhFeGNsOiBudW1iZXIpOiBudW1iZXIge1xuICAgIGNvbnN0IG9yaWdDaGlsZEluZGV4ID0gY2hpbGRJbmRleDtcbiAgICBmb3IgKGxldCBpbmRleCA9IHN0YXJ0SW5kZXg7IGluZGV4IDwgZW5kSW5kZXhFeGNsOyBpbmRleCsrKSB7XG4gICAgICBjb25zdCBmcmFtZSA9IGJhdGNoLnJlZmVyZW5jZUZyYW1lc0VudHJ5KGZyYW1lcywgaW5kZXgpO1xuICAgICAgY29uc3QgbnVtQ2hpbGRyZW5JbnNlcnRlZCA9IHRoaXMuaW5zZXJ0RnJhbWUoYmF0Y2gsIHBhcmVudCwgY2hpbGRJbmRleCwgZnJhbWVzLCBmcmFtZSwgaW5kZXgpO1xuICAgICAgY2hpbGRJbmRleCArPSBudW1DaGlsZHJlbkluc2VydGVkO1xuXG4gICAgICAvLyBTa2lwIG92ZXIgYW55IGRlc2NlbmRhbnRzLCBzaW5jZSB0aGV5IGFyZSBhbHJlYWR5IGRlYWx0IHdpdGggcmVjdXJzaXZlbHlcbiAgICAgIGluZGV4ICs9IGNvdW50RGVzY2VuZGFudEZyYW1lcyhiYXRjaCwgZnJhbWUpO1xuICAgIH1cblxuICAgIHJldHVybiAoY2hpbGRJbmRleCAtIG9yaWdDaGlsZEluZGV4KTsgLy8gVG90YWwgbnVtYmVyIG9mIGNoaWxkcmVuIGluc2VydGVkXG4gIH1cbn1cblxuZnVuY3Rpb24gcGFyc2VNYXJrdXAobWFya3VwOiBzdHJpbmcsIGlzU3ZnOiBib29sZWFuKSB7XG4gIGlmIChpc1N2Zykge1xuICAgIHNoYXJlZFN2Z0VsZW1Gb3JQYXJzaW5nLmlubmVySFRNTCA9IG1hcmt1cCB8fCAnICc7XG4gICAgcmV0dXJuIHNoYXJlZFN2Z0VsZW1Gb3JQYXJzaW5nO1xuICB9IGVsc2Uge1xuICAgIHNoYXJlZFRlbXBsYXRlRWxlbUZvclBhcnNpbmcuaW5uZXJIVE1MID0gbWFya3VwIHx8ICcgJztcbiAgICByZXR1cm4gc2hhcmVkVGVtcGxhdGVFbGVtRm9yUGFyc2luZy5jb250ZW50O1xuICB9XG59XG5cbmZ1bmN0aW9uIGNvdW50RGVzY2VuZGFudEZyYW1lcyhiYXRjaDogUmVuZGVyQmF0Y2gsIGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpOiBudW1iZXIge1xuICBjb25zdCBmcmFtZVJlYWRlciA9IGJhdGNoLmZyYW1lUmVhZGVyO1xuICBzd2l0Y2ggKGZyYW1lUmVhZGVyLmZyYW1lVHlwZShmcmFtZSkpIHtcbiAgICAvLyBUaGUgZm9sbG93aW5nIGZyYW1lIHR5cGVzIGhhdmUgYSBzdWJ0cmVlIGxlbmd0aC4gT3RoZXIgZnJhbWVzIG1heSB1c2UgdGhhdCBtZW1vcnkgc2xvdFxuICAgIC8vIHRvIG1lYW4gc29tZXRoaW5nIGVsc2UsIHNvIHdlIG11c3Qgbm90IHJlYWQgaXQuIFdlIHNob3VsZCBjb25zaWRlciBoYXZpbmcgbm9taW5hbCBzdWJ0eXBlc1xuICAgIC8vIG9mIFJlbmRlclRyZWVGcmFtZVBvaW50ZXIgdGhhdCBwcmV2ZW50IGFjY2VzcyB0byBub24tYXBwbGljYWJsZSBmaWVsZHMuXG4gICAgY2FzZSBGcmFtZVR5cGUuY29tcG9uZW50OlxuICAgIGNhc2UgRnJhbWVUeXBlLmVsZW1lbnQ6XG4gICAgY2FzZSBGcmFtZVR5cGUucmVnaW9uOlxuICAgICAgcmV0dXJuIGZyYW1lUmVhZGVyLnN1YnRyZWVMZW5ndGgoZnJhbWUpIC0gMTtcbiAgICBkZWZhdWx0OlxuICAgICAgcmV0dXJuIDA7XG4gIH1cbn1cblxuZnVuY3Rpb24gcmFpc2VFdmVudChldmVudDogRXZlbnQsIGJyb3dzZXJSZW5kZXJlcklkOiBudW1iZXIsIGV2ZW50SGFuZGxlcklkOiBudW1iZXIsIGV2ZW50QXJnczogRXZlbnRGb3JEb3ROZXQ8VUlFdmVudEFyZ3M+KSB7XG4gIGlmIChwcmV2ZW50RGVmYXVsdEV2ZW50c1tldmVudC50eXBlXSkge1xuICAgIGV2ZW50LnByZXZlbnREZWZhdWx0KCk7XG4gIH1cblxuICBjb25zdCBldmVudERlc2NyaXB0b3IgPSB7XG4gICAgYnJvd3NlclJlbmRlcmVySWQsXG4gICAgZXZlbnRIYW5kbGVySWQsXG4gICAgZXZlbnRBcmdzVHlwZTogZXZlbnRBcmdzLnR5cGVcbiAgfTtcblxuICByZXR1cm4gRG90TmV0Lmludm9rZU1ldGhvZEFzeW5jKFxuICAgICdNaWNyb3NvZnQuQXNwTmV0Q29yZS5Db21wb25lbnRzLkJyb3dzZXInLFxuICAgICdEaXNwYXRjaEV2ZW50JyxcbiAgICBldmVudERlc2NyaXB0b3IsXG4gICAgSlNPTi5zdHJpbmdpZnkoZXZlbnRBcmdzLmRhdGEpKTtcbn1cblxuZnVuY3Rpb24gY2xlYXJFbGVtZW50KGVsZW1lbnQ6IEVsZW1lbnQpIHtcbiAgbGV0IGNoaWxkTm9kZTogTm9kZSB8IG51bGw7XG4gIHdoaWxlIChjaGlsZE5vZGUgPSBlbGVtZW50LmZpcnN0Q2hpbGQpIHtcbiAgICBlbGVtZW50LnJlbW92ZUNoaWxkKGNoaWxkTm9kZSk7XG4gIH1cbn1cbiIsImV4cG9ydCBmdW5jdGlvbiBhcHBseUNhcHR1cmVJZFRvRWxlbWVudChlbGVtZW50OiBFbGVtZW50LCByZWZlcmVuY2VDYXB0dXJlSWQ6IHN0cmluZykge1xuICBlbGVtZW50LnNldEF0dHJpYnV0ZShnZXRDYXB0dXJlSWRBdHRyaWJ1dGVOYW1lKHJlZmVyZW5jZUNhcHR1cmVJZCksICcnKTtcbn1cblxuZnVuY3Rpb24gZ2V0RWxlbWVudEJ5Q2FwdHVyZUlkKHJlZmVyZW5jZUNhcHR1cmVJZDogc3RyaW5nKSB7XG4gIGNvbnN0IHNlbGVjdG9yID0gYFske2dldENhcHR1cmVJZEF0dHJpYnV0ZU5hbWUocmVmZXJlbmNlQ2FwdHVyZUlkKX1dYDtcbiAgcmV0dXJuIGRvY3VtZW50LnF1ZXJ5U2VsZWN0b3Ioc2VsZWN0b3IpO1xufVxuXG5mdW5jdGlvbiBnZXRDYXB0dXJlSWRBdHRyaWJ1dGVOYW1lKHJlZmVyZW5jZUNhcHR1cmVJZDogc3RyaW5nKSB7XG4gIHJldHVybiBgX2JsXyR7cmVmZXJlbmNlQ2FwdHVyZUlkfWA7XG59XG5cbi8vIFN1cHBvcnQgcmVjZWl2aW5nIEVsZW1lbnRSZWYgaW5zdGFuY2VzIGFzIGFyZ3MgaW4gaW50ZXJvcCBjYWxsc1xuY29uc3QgZWxlbWVudFJlZktleSA9ICdfYmxhem9yRWxlbWVudFJlZic7IC8vIEtlZXAgaW4gc3luYyB3aXRoIEVsZW1lbnRSZWYuY3NcbkRvdE5ldC5hdHRhY2hSZXZpdmVyKChrZXksIHZhbHVlKSA9PiB7XG4gIGlmICh2YWx1ZSAmJiB0eXBlb2YgdmFsdWUgPT09ICdvYmplY3QnICYmIHZhbHVlLmhhc093blByb3BlcnR5KGVsZW1lbnRSZWZLZXkpICYmIHR5cGVvZiB2YWx1ZVtlbGVtZW50UmVmS2V5XSA9PT0gJ3N0cmluZycpIHtcbiAgICByZXR1cm4gZ2V0RWxlbWVudEJ5Q2FwdHVyZUlkKHZhbHVlW2VsZW1lbnRSZWZLZXldKTtcbiAgfSBlbHNlIHtcbiAgICByZXR1cm4gdmFsdWU7XG4gIH1cbn0pO1xuIiwiaW1wb3J0IHsgRXZlbnRGb3JEb3ROZXQsIFVJRXZlbnRBcmdzIH0gZnJvbSAnLi9FdmVudEZvckRvdE5ldCc7XG5cbmNvbnN0IG5vbkJ1YmJsaW5nRXZlbnRzID0gdG9Mb29rdXAoW1xuICAnYWJvcnQnLCAnYmx1cicsICdjaGFuZ2UnLCAnZXJyb3InLCAnZm9jdXMnLCAnbG9hZCcsICdsb2FkZW5kJywgJ2xvYWRzdGFydCcsICdtb3VzZWVudGVyJywgJ21vdXNlbGVhdmUnLFxuICAncHJvZ3Jlc3MnLCAncmVzZXQnLCAnc2Nyb2xsJywgJ3N1Ym1pdCcsICd1bmxvYWQnLCAnRE9NTm9kZUluc2VydGVkSW50b0RvY3VtZW50JywgJ0RPTU5vZGVSZW1vdmVkRnJvbURvY3VtZW50J1xuXSk7XG5cbmV4cG9ydCBpbnRlcmZhY2UgT25FdmVudENhbGxiYWNrIHtcbiAgKGV2ZW50OiBFdmVudCwgZXZlbnRIYW5kbGVySWQ6IG51bWJlciwgZXZlbnRBcmdzOiBFdmVudEZvckRvdE5ldDxVSUV2ZW50QXJncz4pOiB2b2lkO1xufVxuXG4vLyBSZXNwb25zaWJsZSBmb3IgYWRkaW5nL3JlbW92aW5nIHRoZSBldmVudEluZm8gb24gYW4gZXhwYW5kbyBwcm9wZXJ0eSBvbiBET00gZWxlbWVudHMsIGFuZFxuLy8gY2FsbGluZyBhbiBFdmVudEluZm9TdG9yZSB0aGF0IGRlYWxzIHdpdGggcmVnaXN0ZXJpbmcvdW5yZWdpc3RlcmluZyB0aGUgdW5kZXJseWluZyBkZWxlZ2F0ZWRcbi8vIGV2ZW50IGxpc3RlbmVycyBhcyByZXF1aXJlZCAoYW5kIGFsc28gbWFwcyBhY3R1YWwgZXZlbnRzIGJhY2sgdG8gdGhlIGdpdmVuIGNhbGxiYWNrKS5cbmV4cG9ydCBjbGFzcyBFdmVudERlbGVnYXRvciB7XG4gIHByaXZhdGUgc3RhdGljIG5leHRFdmVudERlbGVnYXRvcklkID0gMDtcbiAgcHJpdmF0ZSBldmVudHNDb2xsZWN0aW9uS2V5OiBzdHJpbmc7XG4gIHByaXZhdGUgZXZlbnRJbmZvU3RvcmU6IEV2ZW50SW5mb1N0b3JlO1xuXG4gIGNvbnN0cnVjdG9yKHByaXZhdGUgb25FdmVudDogT25FdmVudENhbGxiYWNrKSB7XG4gICAgY29uc3QgZXZlbnREZWxlZ2F0b3JJZCA9ICsrRXZlbnREZWxlZ2F0b3IubmV4dEV2ZW50RGVsZWdhdG9ySWQ7XG4gICAgdGhpcy5ldmVudHNDb2xsZWN0aW9uS2V5ID0gYF9ibGF6b3JFdmVudHNfJHtldmVudERlbGVnYXRvcklkfWA7XG4gICAgdGhpcy5ldmVudEluZm9TdG9yZSA9IG5ldyBFdmVudEluZm9TdG9yZSh0aGlzLm9uR2xvYmFsRXZlbnQuYmluZCh0aGlzKSk7XG4gIH1cblxuICBwdWJsaWMgc2V0TGlzdGVuZXIoZWxlbWVudDogRWxlbWVudCwgZXZlbnROYW1lOiBzdHJpbmcsIGV2ZW50SGFuZGxlcklkOiBudW1iZXIpIHtcbiAgICAvLyBFbnN1cmUgd2UgaGF2ZSBhIHBsYWNlIHRvIHN0b3JlIGV2ZW50IGluZm8gZm9yIHRoaXMgZWxlbWVudFxuICAgIGxldCBpbmZvRm9yRWxlbWVudDogRXZlbnRIYW5kbGVySW5mb3NGb3JFbGVtZW50ID0gZWxlbWVudFt0aGlzLmV2ZW50c0NvbGxlY3Rpb25LZXldO1xuICAgIGlmICghaW5mb0ZvckVsZW1lbnQpIHtcbiAgICAgIGluZm9Gb3JFbGVtZW50ID0gZWxlbWVudFt0aGlzLmV2ZW50c0NvbGxlY3Rpb25LZXldID0ge307XG4gICAgfVxuXG4gICAgaWYgKGluZm9Gb3JFbGVtZW50Lmhhc093blByb3BlcnR5KGV2ZW50TmFtZSkpIHtcbiAgICAgIC8vIFdlIGNhbiBjaGVhcGx5IHVwZGF0ZSB0aGUgaW5mbyBvbiB0aGUgZXhpc3Rpbmcgb2JqZWN0IGFuZCBkb24ndCBuZWVkIGFueSBvdGhlciBob3VzZWtlZXBpbmdcbiAgICAgIGNvbnN0IG9sZEluZm8gPSBpbmZvRm9yRWxlbWVudFtldmVudE5hbWVdO1xuICAgICAgdGhpcy5ldmVudEluZm9TdG9yZS51cGRhdGUob2xkSW5mby5ldmVudEhhbmRsZXJJZCwgZXZlbnRIYW5kbGVySWQpO1xuICAgIH0gZWxzZSB7XG4gICAgICAvLyBHbyB0aHJvdWdoIHRoZSB3aG9sZSBmbG93IHdoaWNoIG1pZ2h0IGludm9sdmUgcmVnaXN0ZXJpbmcgYSBuZXcgZ2xvYmFsIGhhbmRsZXJcbiAgICAgIGNvbnN0IG5ld0luZm8gPSB7IGVsZW1lbnQsIGV2ZW50TmFtZSwgZXZlbnRIYW5kbGVySWQgfTtcbiAgICAgIHRoaXMuZXZlbnRJbmZvU3RvcmUuYWRkKG5ld0luZm8pO1xuICAgICAgaW5mb0ZvckVsZW1lbnRbZXZlbnROYW1lXSA9IG5ld0luZm87XG4gICAgfVxuICB9XG5cbiAgcHVibGljIHJlbW92ZUxpc3RlbmVyKGV2ZW50SGFuZGxlcklkOiBudW1iZXIpIHtcbiAgICAvLyBUaGlzIG1ldGhvZCBnZXRzIGNhbGxlZCB3aGVuZXZlciB0aGUgLk5FVC1zaWRlIGNvZGUgcmVwb3J0cyB0aGF0IGEgY2VydGFpbiBldmVudCBoYW5kbGVyXG4gICAgLy8gaGFzIGJlZW4gZGlzcG9zZWQuIEhvd2V2ZXIgd2Ugd2lsbCBhbHJlYWR5IGhhdmUgZGlzcG9zZWQgdGhlIGluZm8gYWJvdXQgdGhhdCBoYW5kbGVyIGlmXG4gICAgLy8gdGhlIGV2ZW50SGFuZGxlcklkIGZvciB0aGUgKGVsZW1lbnQsZXZlbnROYW1lKSBwYWlyIHdhcyByZXBsYWNlZCBkdXJpbmcgZGlmZiBhcHBsaWNhdGlvbi5cbiAgICBjb25zdCBpbmZvID0gdGhpcy5ldmVudEluZm9TdG9yZS5yZW1vdmUoZXZlbnRIYW5kbGVySWQpO1xuICAgIGlmIChpbmZvKSB7XG4gICAgICAvLyBMb29rcyBsaWtlIHRoaXMgZXZlbnQgaGFuZGxlciB3YXNuJ3QgYWxyZWFkeSBkaXNwb3NlZFxuICAgICAgLy8gUmVtb3ZlIHRoZSBhc3NvY2lhdGVkIGRhdGEgZnJvbSB0aGUgRE9NIGVsZW1lbnRcbiAgICAgIGNvbnN0IGVsZW1lbnQgPSBpbmZvLmVsZW1lbnQ7XG4gICAgICBpZiAoZWxlbWVudC5oYXNPd25Qcm9wZXJ0eSh0aGlzLmV2ZW50c0NvbGxlY3Rpb25LZXkpKSB7XG4gICAgICAgIGNvbnN0IGVsZW1lbnRFdmVudEluZm9zOiBFdmVudEhhbmRsZXJJbmZvc0ZvckVsZW1lbnQgPSBlbGVtZW50W3RoaXMuZXZlbnRzQ29sbGVjdGlvbktleV07XG4gICAgICAgIGRlbGV0ZSBlbGVtZW50RXZlbnRJbmZvc1tpbmZvLmV2ZW50TmFtZV07XG4gICAgICAgIGlmIChPYmplY3QuZ2V0T3duUHJvcGVydHlOYW1lcyhlbGVtZW50RXZlbnRJbmZvcykubGVuZ3RoID09PSAwKSB7XG4gICAgICAgICAgZGVsZXRlIGVsZW1lbnRbdGhpcy5ldmVudHNDb2xsZWN0aW9uS2V5XTtcbiAgICAgICAgfVxuICAgICAgfVxuICAgIH1cbiAgfVxuXG4gIHByaXZhdGUgb25HbG9iYWxFdmVudChldnQ6IEV2ZW50KSB7XG4gICAgaWYgKCEoZXZ0LnRhcmdldCBpbnN0YW5jZW9mIEVsZW1lbnQpKSB7XG4gICAgICByZXR1cm47XG4gICAgfVxuXG4gICAgLy8gU2NhbiB1cCB0aGUgZWxlbWVudCBoaWVyYXJjaHksIGxvb2tpbmcgZm9yIGFueSBtYXRjaGluZyByZWdpc3RlcmVkIGV2ZW50IGhhbmRsZXJzXG4gICAgbGV0IGNhbmRpZGF0ZUVsZW1lbnQgPSBldnQudGFyZ2V0IGFzIEVsZW1lbnQgfCBudWxsO1xuICAgIGxldCBldmVudEFyZ3M6IEV2ZW50Rm9yRG90TmV0PFVJRXZlbnRBcmdzPiB8IG51bGwgPSBudWxsOyAvLyBQb3B1bGF0ZSBsYXppbHlcbiAgICBjb25zdCBldmVudElzTm9uQnViYmxpbmcgPSBub25CdWJibGluZ0V2ZW50cy5oYXNPd25Qcm9wZXJ0eShldnQudHlwZSk7XG4gICAgd2hpbGUgKGNhbmRpZGF0ZUVsZW1lbnQpIHtcbiAgICAgIGlmIChjYW5kaWRhdGVFbGVtZW50Lmhhc093blByb3BlcnR5KHRoaXMuZXZlbnRzQ29sbGVjdGlvbktleSkpIHtcbiAgICAgICAgY29uc3QgaGFuZGxlckluZm9zID0gY2FuZGlkYXRlRWxlbWVudFt0aGlzLmV2ZW50c0NvbGxlY3Rpb25LZXldO1xuICAgICAgICBpZiAoaGFuZGxlckluZm9zLmhhc093blByb3BlcnR5KGV2dC50eXBlKSkge1xuICAgICAgICAgIC8vIFdlIGFyZSBnb2luZyB0byByYWlzZSBhbiBldmVudCBmb3IgdGhpcyBlbGVtZW50LCBzbyBwcmVwYXJlIGluZm8gbmVlZGVkIGJ5IHRoZSAuTkVUIGNvZGVcbiAgICAgICAgICBpZiAoIWV2ZW50QXJncykge1xuICAgICAgICAgICAgZXZlbnRBcmdzID0gRXZlbnRGb3JEb3ROZXQuZnJvbURPTUV2ZW50KGV2dCk7XG4gICAgICAgICAgfVxuXG4gICAgICAgICAgY29uc3QgaGFuZGxlckluZm8gPSBoYW5kbGVySW5mb3NbZXZ0LnR5cGVdO1xuICAgICAgICAgIHRoaXMub25FdmVudChldnQsIGhhbmRsZXJJbmZvLmV2ZW50SGFuZGxlcklkLCBldmVudEFyZ3MpO1xuICAgICAgICB9XG4gICAgICB9XG5cbiAgICAgIGNhbmRpZGF0ZUVsZW1lbnQgPSBldmVudElzTm9uQnViYmxpbmcgPyBudWxsIDogY2FuZGlkYXRlRWxlbWVudC5wYXJlbnRFbGVtZW50O1xuICAgIH1cbiAgfVxufVxuXG4vLyBSZXNwb25zaWJsZSBmb3IgYWRkaW5nIGFuZCByZW1vdmluZyB0aGUgZ2xvYmFsIGxpc3RlbmVyIHdoZW4gdGhlIG51bWJlciBvZiBsaXN0ZW5lcnNcbi8vIGZvciBhIGdpdmVuIGV2ZW50IG5hbWUgY2hhbmdlcyBiZXR3ZWVuIHplcm8gYW5kIG5vbnplcm9cbmNsYXNzIEV2ZW50SW5mb1N0b3JlIHtcbiAgcHJpdmF0ZSBpbmZvc0J5RXZlbnRIYW5kbGVySWQ6IHsgW2V2ZW50SGFuZGxlcklkOiBudW1iZXJdOiBFdmVudEhhbmRsZXJJbmZvIH0gPSB7fTtcbiAgcHJpdmF0ZSBjb3VudEJ5RXZlbnROYW1lOiB7IFtldmVudE5hbWU6IHN0cmluZ106IG51bWJlciB9ID0ge307XG5cbiAgY29uc3RydWN0b3IocHJpdmF0ZSBnbG9iYWxMaXN0ZW5lcjogRXZlbnRMaXN0ZW5lcikge1xuICB9XG5cbiAgcHVibGljIGFkZChpbmZvOiBFdmVudEhhbmRsZXJJbmZvKSB7XG4gICAgaWYgKHRoaXMuaW5mb3NCeUV2ZW50SGFuZGxlcklkW2luZm8uZXZlbnRIYW5kbGVySWRdKSB7XG4gICAgICAvLyBTaG91bGQgbmV2ZXIgaGFwcGVuLCBidXQgd2Ugd2FudCB0byBrbm93IGlmIGl0IGRvZXNcbiAgICAgIHRocm93IG5ldyBFcnJvcihgRXZlbnQgJHtpbmZvLmV2ZW50SGFuZGxlcklkfSBpcyBhbHJlYWR5IHRyYWNrZWRgKTtcbiAgICB9XG5cbiAgICB0aGlzLmluZm9zQnlFdmVudEhhbmRsZXJJZFtpbmZvLmV2ZW50SGFuZGxlcklkXSA9IGluZm87XG5cbiAgICBjb25zdCBldmVudE5hbWUgPSBpbmZvLmV2ZW50TmFtZTtcbiAgICBpZiAodGhpcy5jb3VudEJ5RXZlbnROYW1lLmhhc093blByb3BlcnR5KGV2ZW50TmFtZSkpIHtcbiAgICAgIHRoaXMuY291bnRCeUV2ZW50TmFtZVtldmVudE5hbWVdKys7XG4gICAgfSBlbHNlIHtcbiAgICAgIHRoaXMuY291bnRCeUV2ZW50TmFtZVtldmVudE5hbWVdID0gMTtcblxuICAgICAgLy8gVG8gbWFrZSBkZWxlZ2F0aW9uIHdvcmsgd2l0aCBub24tYnViYmxpbmcgZXZlbnRzLCByZWdpc3RlciBhICdjYXB0dXJlJyBsaXN0ZW5lci5cbiAgICAgIC8vIFdlIHByZXNlcnZlIHRoZSBub24tYnViYmxpbmcgYmVoYXZpb3IgYnkgb25seSBkaXNwYXRjaGluZyBzdWNoIGV2ZW50cyB0byB0aGUgdGFyZ2V0ZWQgZWxlbWVudC5cbiAgICAgIGNvbnN0IHVzZUNhcHR1cmUgPSBub25CdWJibGluZ0V2ZW50cy5oYXNPd25Qcm9wZXJ0eShldmVudE5hbWUpO1xuICAgICAgZG9jdW1lbnQuYWRkRXZlbnRMaXN0ZW5lcihldmVudE5hbWUsIHRoaXMuZ2xvYmFsTGlzdGVuZXIsIHVzZUNhcHR1cmUpO1xuICAgIH1cbiAgfVxuXG4gIHB1YmxpYyB1cGRhdGUob2xkRXZlbnRIYW5kbGVySWQ6IG51bWJlciwgbmV3RXZlbnRIYW5kbGVySWQ6IG51bWJlcikge1xuICAgIGlmICh0aGlzLmluZm9zQnlFdmVudEhhbmRsZXJJZC5oYXNPd25Qcm9wZXJ0eShuZXdFdmVudEhhbmRsZXJJZCkpIHtcbiAgICAgIC8vIFNob3VsZCBuZXZlciBoYXBwZW4sIGJ1dCB3ZSB3YW50IHRvIGtub3cgaWYgaXQgZG9lc1xuICAgICAgdGhyb3cgbmV3IEVycm9yKGBFdmVudCAke25ld0V2ZW50SGFuZGxlcklkfSBpcyBhbHJlYWR5IHRyYWNrZWRgKTtcbiAgICB9XG5cbiAgICAvLyBTaW5jZSB3ZSdyZSBqdXN0IHVwZGF0aW5nIHRoZSBldmVudCBoYW5kbGVyIElELCB0aGVyZSdzIG5vIG5lZWQgdG8gdXBkYXRlIHRoZSBnbG9iYWwgY291bnRzXG4gICAgY29uc3QgaW5mbyA9IHRoaXMuaW5mb3NCeUV2ZW50SGFuZGxlcklkW29sZEV2ZW50SGFuZGxlcklkXTtcbiAgICBkZWxldGUgdGhpcy5pbmZvc0J5RXZlbnRIYW5kbGVySWRbb2xkRXZlbnRIYW5kbGVySWRdO1xuICAgIGluZm8uZXZlbnRIYW5kbGVySWQgPSBuZXdFdmVudEhhbmRsZXJJZDtcbiAgICB0aGlzLmluZm9zQnlFdmVudEhhbmRsZXJJZFtuZXdFdmVudEhhbmRsZXJJZF0gPSBpbmZvO1xuICB9XG5cbiAgcHVibGljIHJlbW92ZShldmVudEhhbmRsZXJJZDogbnVtYmVyKTogRXZlbnRIYW5kbGVySW5mbyB7XG4gICAgY29uc3QgaW5mbyA9IHRoaXMuaW5mb3NCeUV2ZW50SGFuZGxlcklkW2V2ZW50SGFuZGxlcklkXTtcbiAgICBpZiAoaW5mbykge1xuICAgICAgZGVsZXRlIHRoaXMuaW5mb3NCeUV2ZW50SGFuZGxlcklkW2V2ZW50SGFuZGxlcklkXTtcblxuICAgICAgY29uc3QgZXZlbnROYW1lID0gaW5mby5ldmVudE5hbWU7XG4gICAgICBpZiAoLS10aGlzLmNvdW50QnlFdmVudE5hbWVbZXZlbnROYW1lXSA9PT0gMCkge1xuICAgICAgICBkZWxldGUgdGhpcy5jb3VudEJ5RXZlbnROYW1lW2V2ZW50TmFtZV07XG4gICAgICAgIGRvY3VtZW50LnJlbW92ZUV2ZW50TGlzdGVuZXIoZXZlbnROYW1lLCB0aGlzLmdsb2JhbExpc3RlbmVyKTtcbiAgICAgIH1cbiAgICB9XG5cbiAgICByZXR1cm4gaW5mbztcbiAgfVxufVxuXG5pbnRlcmZhY2UgRXZlbnRIYW5kbGVySW5mb3NGb3JFbGVtZW50IHtcbiAgLy8gQWx0aG91Z2ggd2UgKmNvdWxkKiB0cmFjayBtdWx0aXBsZSBldmVudCBoYW5kbGVycyBwZXIgKGVsZW1lbnQsIGV2ZW50TmFtZSkgcGFpclxuICAvLyAoc2luY2UgdGhleSBoYXZlIGRpc3RpbmN0IGV2ZW50SGFuZGxlcklkIHZhbHVlcyksIHRoZXJlJ3Mgbm8gcG9pbnQgZG9pbmcgc28gYmVjYXVzZVxuICAvLyBvdXIgcHJvZ3JhbW1pbmcgbW9kZWwgaXMgdGhhdCB5b3UgZGVjbGFyZSBldmVudCBoYW5kbGVycyBhcyBhdHRyaWJ1dGVzLiBBbiBlbGVtZW50XG4gIC8vIGNhbiBvbmx5IGhhdmUgb25lIGF0dHJpYnV0ZSB3aXRoIGEgZ2l2ZW4gbmFtZSwgaGVuY2Ugb25seSBvbmUgZXZlbnQgaGFuZGxlciB3aXRoXG4gIC8vIHRoYXQgbmFtZSBhdCBhbnkgb25lIHRpbWUuXG4gIC8vIFNvIHRvIGtlZXAgdGhpbmdzIHNpbXBsZSwgb25seSB0cmFjayBvbmUgRXZlbnRIYW5kbGVySW5mbyBwZXIgKGVsZW1lbnQsIGV2ZW50TmFtZSlcbiAgW2V2ZW50TmFtZTogc3RyaW5nXTogRXZlbnRIYW5kbGVySW5mb1xufVxuXG5pbnRlcmZhY2UgRXZlbnRIYW5kbGVySW5mbyB7XG4gIGVsZW1lbnQ6IEVsZW1lbnQ7XG4gIGV2ZW50TmFtZTogc3RyaW5nO1xuICBldmVudEhhbmRsZXJJZDogbnVtYmVyO1xufVxuXG5mdW5jdGlvbiB0b0xvb2t1cChpdGVtczogc3RyaW5nW10pOiB7IFtrZXk6IHN0cmluZ106IGJvb2xlYW4gfSB7XG4gIGNvbnN0IHJlc3VsdCA9IHt9O1xuICBpdGVtcy5mb3JFYWNoKHZhbHVlID0+IHsgcmVzdWx0W3ZhbHVlXSA9IHRydWU7IH0pO1xuICByZXR1cm4gcmVzdWx0O1xufVxuIiwiZXhwb3J0IGNsYXNzIEV2ZW50Rm9yRG90TmV0PFREYXRhIGV4dGVuZHMgVUlFdmVudEFyZ3M+IHtcbiAgY29uc3RydWN0b3IocHVibGljIHJlYWRvbmx5IHR5cGU6IEV2ZW50QXJnc1R5cGUsIHB1YmxpYyByZWFkb25seSBkYXRhOiBURGF0YSkge1xuICB9XG5cbiAgc3RhdGljIGZyb21ET01FdmVudChldmVudDogRXZlbnQpOiBFdmVudEZvckRvdE5ldDxVSUV2ZW50QXJncz4ge1xuICAgIGNvbnN0IGVsZW1lbnQgPSBldmVudC50YXJnZXQgYXMgRWxlbWVudDtcbiAgICBzd2l0Y2ggKGV2ZW50LnR5cGUpIHtcblxuICAgICAgY2FzZSAnaW5wdXQnOlxuICAgICAgY2FzZSAnY2hhbmdlJzoge1xuICAgICAgICBjb25zdCB0YXJnZXRJc0NoZWNrYm94ID0gaXNDaGVja2JveChlbGVtZW50KTtcbiAgICAgICAgY29uc3QgbmV3VmFsdWUgPSB0YXJnZXRJc0NoZWNrYm94ID8gISFlbGVtZW50WydjaGVja2VkJ10gOiBlbGVtZW50Wyd2YWx1ZSddO1xuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJQ2hhbmdlRXZlbnRBcmdzPignY2hhbmdlJywgeyB0eXBlOiBldmVudC50eXBlLCB2YWx1ZTogbmV3VmFsdWUgfSk7XG4gICAgICB9XG5cbiAgICAgIGNhc2UgJ2NvcHknOlxuICAgICAgY2FzZSAnY3V0JzpcbiAgICAgIGNhc2UgJ3Bhc3RlJzpcbiAgICAgICAgcmV0dXJuIG5ldyBFdmVudEZvckRvdE5ldDxVSUNsaXBib2FyZEV2ZW50QXJncz4oJ2NsaXBib2FyZCcsIHsgdHlwZTogZXZlbnQudHlwZSB9KTtcblxuICAgICAgY2FzZSAnZHJhZyc6XG4gICAgICBjYXNlICdkcmFnZW5kJzpcbiAgICAgIGNhc2UgJ2RyYWdlbnRlcic6XG4gICAgICBjYXNlICdkcmFnbGVhdmUnOlxuICAgICAgY2FzZSAnZHJhZ292ZXInOlxuICAgICAgY2FzZSAnZHJhZ3N0YXJ0JzpcbiAgICAgIGNhc2UgJ2Ryb3AnOlxuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJRHJhZ0V2ZW50QXJncz4oJ2RyYWcnLCBwYXJzZURyYWdFdmVudChldmVudCkpO1xuXG4gICAgICBjYXNlICdmb2N1cyc6XG4gICAgICBjYXNlICdibHVyJzpcbiAgICAgIGNhc2UgJ2ZvY3VzaW4nOlxuICAgICAgY2FzZSAnZm9jdXNvdXQnOlxuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJRm9jdXNFdmVudEFyZ3M+KCdmb2N1cycsIHsgdHlwZTogZXZlbnQudHlwZSB9KTtcblxuICAgICAgY2FzZSAna2V5ZG93bic6XG4gICAgICBjYXNlICdrZXl1cCc6XG4gICAgICBjYXNlICdrZXlwcmVzcyc6XG4gICAgICAgIHJldHVybiBuZXcgRXZlbnRGb3JEb3ROZXQ8VUlLZXlib2FyZEV2ZW50QXJncz4oJ2tleWJvYXJkJywgcGFyc2VLZXlib2FyZEV2ZW50KDxLZXlib2FyZEV2ZW50PmV2ZW50KSk7XG5cbiAgICAgIGNhc2UgJ2NvbnRleHRtZW51JzpcbiAgICAgIGNhc2UgJ2NsaWNrJzpcbiAgICAgIGNhc2UgJ21vdXNlb3Zlcic6XG4gICAgICBjYXNlICdtb3VzZW91dCc6XG4gICAgICBjYXNlICdtb3VzZW1vdmUnOlxuICAgICAgY2FzZSAnbW91c2Vkb3duJzpcbiAgICAgIGNhc2UgJ21vdXNldXAnOlxuICAgICAgY2FzZSAnZGJsY2xpY2snOlxuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJTW91c2VFdmVudEFyZ3M+KCdtb3VzZScsIHBhcnNlTW91c2VFdmVudCg8TW91c2VFdmVudD5ldmVudCkpO1xuXG4gICAgICBjYXNlICdlcnJvcic6XG4gICAgICAgIHJldHVybiBuZXcgRXZlbnRGb3JEb3ROZXQ8VUlFcnJvckV2ZW50QXJncz4oJ2Vycm9yJywgcGFyc2VFcnJvckV2ZW50KDxFcnJvckV2ZW50PmV2ZW50KSk7XG5cbiAgICAgIGNhc2UgJ2xvYWRzdGFydCc6XG4gICAgICBjYXNlICd0aW1lb3V0JzpcbiAgICAgIGNhc2UgJ2Fib3J0JzpcbiAgICAgIGNhc2UgJ2xvYWQnOlxuICAgICAgY2FzZSAnbG9hZGVuZCc6XG4gICAgICBjYXNlICdwcm9ncmVzcyc6XG4gICAgICAgIHJldHVybiBuZXcgRXZlbnRGb3JEb3ROZXQ8VUlQcm9ncmVzc0V2ZW50QXJncz4oJ3Byb2dyZXNzJywgcGFyc2VQcm9ncmVzc0V2ZW50KDxQcm9ncmVzc0V2ZW50PmV2ZW50KSk7XG5cbiAgICAgIGNhc2UgJ3RvdWNoY2FuY2VsJzpcbiAgICAgIGNhc2UgJ3RvdWNoZW5kJzpcbiAgICAgIGNhc2UgJ3RvdWNobW92ZSc6XG4gICAgICBjYXNlICd0b3VjaGVudGVyJzpcbiAgICAgIGNhc2UgJ3RvdWNobGVhdmUnOlxuICAgICAgY2FzZSAndG91Y2hzdGFydCc6XG4gICAgICAgIHJldHVybiBuZXcgRXZlbnRGb3JEb3ROZXQ8VUlUb3VjaEV2ZW50QXJncz4oJ3RvdWNoJywgcGFyc2VUb3VjaEV2ZW50KDxUb3VjaEV2ZW50PmV2ZW50KSk7XG5cbiAgICAgIGNhc2UgJ2dvdHBvaW50ZXJjYXB0dXJlJzpcbiAgICAgIGNhc2UgJ2xvc3Rwb2ludGVyY2FwdHVyZSc6XG4gICAgICBjYXNlICdwb2ludGVyY2FuY2VsJzpcbiAgICAgIGNhc2UgJ3BvaW50ZXJkb3duJzpcbiAgICAgIGNhc2UgJ3BvaW50ZXJlbnRlcic6XG4gICAgICBjYXNlICdwb2ludGVybGVhdmUnOlxuICAgICAgY2FzZSAncG9pbnRlcm1vdmUnOlxuICAgICAgY2FzZSAncG9pbnRlcm91dCc6XG4gICAgICBjYXNlICdwb2ludGVyb3Zlcic6XG4gICAgICBjYXNlICdwb2ludGVydXAnOlxuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJUG9pbnRlckV2ZW50QXJncz4oJ3BvaW50ZXInLCBwYXJzZVBvaW50ZXJFdmVudCg8UG9pbnRlckV2ZW50PmV2ZW50KSk7XG5cbiAgICAgIGNhc2UgJ3doZWVsJzpcbiAgICAgIGNhc2UgJ21vdXNld2hlZWwnOlxuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJV2hlZWxFdmVudEFyZ3M+KCd3aGVlbCcsIHBhcnNlV2hlZWxFdmVudCg8V2hlZWxFdmVudD5ldmVudCkpO1xuXG4gICAgICBkZWZhdWx0OlxuICAgICAgICByZXR1cm4gbmV3IEV2ZW50Rm9yRG90TmV0PFVJRXZlbnRBcmdzPigndW5rbm93bicsIHsgdHlwZTogZXZlbnQudHlwZSB9KTtcbiAgICB9XG4gIH1cbn1cblxuZnVuY3Rpb24gcGFyc2VEcmFnRXZlbnQoZXZlbnQ6IGFueSkge1xuICByZXR1cm4ge1xuICAgIHR5cGU6IGV2ZW50LnR5cGUsXG4gICAgZGV0YWlsOiBldmVudC5kZXRhaWwsXG4gICAgZGF0YVRyYW5zZmVyOiBldmVudC5kYXRhVHJhbnNmZXIsXG4gICAgc2NyZWVuWDogZXZlbnQuc2NyZWVuWCxcbiAgICBzY3JlZW5ZOiBldmVudC5zY3JlZW5ZLFxuICAgIGNsaWVudFg6IGV2ZW50LmNsaWVudFgsXG4gICAgY2xpZW50WTogZXZlbnQuY2xpZW50WSxcbiAgICBidXR0b246IGV2ZW50LmJ1dHRvbixcbiAgICBidXR0b25zOiBldmVudC5idXR0b25zLFxuICAgIGN0cmxLZXk6IGV2ZW50LmN0cmxLZXksXG4gICAgc2hpZnRLZXk6IGV2ZW50LnNoaWZ0S2V5LFxuICAgIGFsdEtleTogZXZlbnQuYWx0S2V5LFxuICAgIG1ldGFLZXk6IGV2ZW50Lm1ldGFLZXlcbiAgfVxufVxuXG5mdW5jdGlvbiBwYXJzZVdoZWVsRXZlbnQoZXZlbnQ6IFdoZWVsRXZlbnQpIHtcbiAgcmV0dXJuIHtcbiAgICAuLi5wYXJzZU1vdXNlRXZlbnQoZXZlbnQpLFxuICAgIGRlbHRhWDogZXZlbnQuZGVsdGFYLFxuICAgIGRlbHRhWTogZXZlbnQuZGVsdGFZLFxuICAgIGRlbHRhWjogZXZlbnQuZGVsdGFaLFxuICAgIGRlbHRhTW9kZTogZXZlbnQuZGVsdGFNb2RlXG4gIH07XG59XG5cbmZ1bmN0aW9uIHBhcnNlRXJyb3JFdmVudChldmVudDogRXJyb3JFdmVudCkge1xuICByZXR1cm4ge1xuICAgIHR5cGU6IGV2ZW50LnR5cGUsXG4gICAgbWVzc2FnZTogZXZlbnQubWVzc2FnZSxcbiAgICBmaWxlbmFtZTogZXZlbnQuZmlsZW5hbWUsXG4gICAgbGluZW5vOiBldmVudC5saW5lbm8sXG4gICAgY29sbm86IGV2ZW50LmNvbG5vXG4gIH1cbn1cblxuZnVuY3Rpb24gcGFyc2VQcm9ncmVzc0V2ZW50KGV2ZW50OiBQcm9ncmVzc0V2ZW50KSB7XG4gIHJldHVybiB7XG4gICAgdHlwZTogZXZlbnQudHlwZSxcbiAgICBsZW5ndGhDb21wdXRhYmxlOiBldmVudC5sZW5ndGhDb21wdXRhYmxlLFxuICAgIGxvYWRlZDogZXZlbnQubG9hZGVkLFxuICAgIHRvdGFsOiBldmVudC50b3RhbFxuICB9O1xufVxuXG5mdW5jdGlvbiBwYXJzZVRvdWNoRXZlbnQoZXZlbnQ6IFRvdWNoRXZlbnQpIHtcblxuICBmdW5jdGlvbiBwYXJzZVRvdWNoKHRvdWNoTGlzdDogVG91Y2hMaXN0KSB7XG4gICAgY29uc3QgdG91Y2hlczogVUlUb3VjaFBvaW50W10gPSBbXTtcbiAgICBcbiAgICBmb3IgKGxldCBpID0gMDsgaSA8IHRvdWNoTGlzdC5sZW5ndGg7IGkrKykge1xuICAgICAgY29uc3QgdG91Y2ggPSB0b3VjaExpc3RbaV07XG4gICAgICB0b3VjaGVzLnB1c2goe1xuICAgICAgICBpZGVudGlmaWVyOiB0b3VjaC5pZGVudGlmaWVyLFxuICAgICAgICBjbGllbnRYOiB0b3VjaC5jbGllbnRYLFxuICAgICAgICBjbGllbnRZOiB0b3VjaC5jbGllbnRZLFxuICAgICAgICBzY3JlZW5YOiB0b3VjaC5zY3JlZW5YLFxuICAgICAgICBzY3JlZW5ZOiB0b3VjaC5zY3JlZW5ZLFxuICAgICAgICBwYWdlWDogdG91Y2gucGFnZVgsXG4gICAgICAgIHBhZ2VZOiB0b3VjaC5wYWdlWVxuICAgICAgfSk7XG4gICAgfVxuICAgIHJldHVybiB0b3VjaGVzO1xuICB9XG5cbiAgcmV0dXJuIHtcbiAgICB0eXBlOiBldmVudC50eXBlLFxuICAgIGRldGFpbDogZXZlbnQuZGV0YWlsLFxuICAgIHRvdWNoZXM6IHBhcnNlVG91Y2goZXZlbnQudG91Y2hlcyksXG4gICAgdGFyZ2V0VG91Y2hlczogcGFyc2VUb3VjaChldmVudC50YXJnZXRUb3VjaGVzKSxcbiAgICBjaGFuZ2VkVG91Y2hlczogcGFyc2VUb3VjaChldmVudC5jaGFuZ2VkVG91Y2hlcyksXG4gICAgY3RybEtleTogZXZlbnQuY3RybEtleSxcbiAgICBzaGlmdEtleTogZXZlbnQuc2hpZnRLZXksXG4gICAgYWx0S2V5OiBldmVudC5hbHRLZXksXG4gICAgbWV0YUtleTogZXZlbnQubWV0YUtleVxuICB9O1xufVxuXG5mdW5jdGlvbiBwYXJzZUtleWJvYXJkRXZlbnQoZXZlbnQ6IEtleWJvYXJkRXZlbnQpIHtcbiAgcmV0dXJuIHtcbiAgICB0eXBlOiBldmVudC50eXBlLFxuICAgIGtleTogZXZlbnQua2V5LFxuICAgIGNvZGU6IGV2ZW50LmNvZGUsXG4gICAgbG9jYXRpb246IGV2ZW50LmxvY2F0aW9uLFxuICAgIHJlcGVhdDogZXZlbnQucmVwZWF0LFxuICAgIGN0cmxLZXk6IGV2ZW50LmN0cmxLZXksXG4gICAgc2hpZnRLZXk6IGV2ZW50LnNoaWZ0S2V5LFxuICAgIGFsdEtleTogZXZlbnQuYWx0S2V5LFxuICAgIG1ldGFLZXk6IGV2ZW50Lm1ldGFLZXlcbiAgfTtcbn1cblxuZnVuY3Rpb24gcGFyc2VQb2ludGVyRXZlbnQoZXZlbnQ6IFBvaW50ZXJFdmVudCkge1xuICByZXR1cm4ge1xuICAgIC4uLnBhcnNlTW91c2VFdmVudChldmVudCksXG4gICAgcG9pbnRlcklkOiBldmVudC5wb2ludGVySWQsXG4gICAgd2lkdGg6IGV2ZW50LndpZHRoLFxuICAgIGhlaWdodDogZXZlbnQuaGVpZ2h0LFxuICAgIHByZXNzdXJlOiBldmVudC5wcmVzc3VyZSxcbiAgICB0aWx0WDogZXZlbnQudGlsdFgsXG4gICAgdGlsdFk6IGV2ZW50LnRpbHRZLFxuICAgIHBvaW50ZXJUeXBlOiBldmVudC5wb2ludGVyVHlwZSxcbiAgICBpc1ByaW1hcnk6IGV2ZW50LmlzUHJpbWFyeVxuICB9O1xufVxuXG5mdW5jdGlvbiBwYXJzZU1vdXNlRXZlbnQoZXZlbnQ6IE1vdXNlRXZlbnQpIHtcbiAgcmV0dXJuIHtcbiAgICB0eXBlOiBldmVudC50eXBlLFxuICAgIGRldGFpbDogZXZlbnQuZGV0YWlsLFxuICAgIHNjcmVlblg6IGV2ZW50LnNjcmVlblgsXG4gICAgc2NyZWVuWTogZXZlbnQuc2NyZWVuWSxcbiAgICBjbGllbnRYOiBldmVudC5jbGllbnRYLFxuICAgIGNsaWVudFk6IGV2ZW50LmNsaWVudFksXG4gICAgYnV0dG9uOiBldmVudC5idXR0b24sXG4gICAgYnV0dG9uczogZXZlbnQuYnV0dG9ucyxcbiAgICBjdHJsS2V5OiBldmVudC5jdHJsS2V5LFxuICAgIHNoaWZ0S2V5OiBldmVudC5zaGlmdEtleSxcbiAgICBhbHRLZXk6IGV2ZW50LmFsdEtleSxcbiAgICBtZXRhS2V5OiBldmVudC5tZXRhS2V5XG4gIH07XG59XG5cbmZ1bmN0aW9uIGlzQ2hlY2tib3goZWxlbWVudDogRWxlbWVudCB8IG51bGwpIHtcbiAgcmV0dXJuIGVsZW1lbnQgJiYgZWxlbWVudC50YWdOYW1lID09PSAnSU5QVVQnICYmIGVsZW1lbnQuZ2V0QXR0cmlidXRlKCd0eXBlJykgPT09ICdjaGVja2JveCc7XG59XG5cbi8vIFRoZSBmb2xsb3dpbmcgaW50ZXJmYWNlcyBtdXN0IGJlIGtlcHQgaW4gc3luYyB3aXRoIHRoZSBVSUV2ZW50QXJncyBDIyBjbGFzc2VzXG5cbnR5cGUgRXZlbnRBcmdzVHlwZSA9ICdjaGFuZ2UnIHwgJ2NsaXBib2FyZCcgfCAnZHJhZycgfCAnZXJyb3InIHwgJ2ZvY3VzJyB8ICdrZXlib2FyZCcgfCAnbW91c2UnIHwgJ3BvaW50ZXInIHwgJ3Byb2dyZXNzJyB8ICd0b3VjaCcgfCAndW5rbm93bicgfCAnd2hlZWwnO1xuXG5leHBvcnQgaW50ZXJmYWNlIFVJRXZlbnRBcmdzIHtcbiAgdHlwZTogc3RyaW5nO1xufVxuXG5pbnRlcmZhY2UgVUlDaGFuZ2VFdmVudEFyZ3MgZXh0ZW5kcyBVSUV2ZW50QXJncyB7XG4gIHZhbHVlOiBzdHJpbmcgfCBib29sZWFuO1xufVxuXG5pbnRlcmZhY2UgVUlDbGlwYm9hcmRFdmVudEFyZ3MgZXh0ZW5kcyBVSUV2ZW50QXJncyB7XG59XG5cbmludGVyZmFjZSBVSURyYWdFdmVudEFyZ3MgZXh0ZW5kcyBVSUV2ZW50QXJncyB7XG4gIGRldGFpbDogbnVtYmVyO1xuICBkYXRhVHJhbnNmZXI6IFVJRGF0YVRyYW5zZmVyO1xuICBzY3JlZW5YOiBudW1iZXI7XG4gIHNjcmVlblk6IG51bWJlcjtcbiAgY2xpZW50WDogbnVtYmVyO1xuICBjbGllbnRZOiBudW1iZXI7XG4gIGJ1dHRvbjogbnVtYmVyO1xuICBidXR0b25zOiBudW1iZXI7XG4gIGN0cmxLZXk6IGJvb2xlYW47XG4gIHNoaWZ0S2V5OiBib29sZWFuO1xuICBhbHRLZXk6IGJvb2xlYW47XG4gIG1ldGFLZXk6IGJvb2xlYW47XG59XG5cbmludGVyZmFjZSBVSURhdGFUcmFuc2ZlciB7XG4gIGRyb3BFZmZlY3Q6IHN0cmluZztcbiAgZWZmZWN0QWxsb3dlZDogc3RyaW5nO1xuICBmaWxlczogc3RyaW5nW107XG4gIGl0ZW1zOiBVSURhdGFUcmFuc2Zlckl0ZW1bXTtcbiAgdHlwZXM6IHN0cmluZ1tdO1xufVxuXG5pbnRlcmZhY2UgVUlEYXRhVHJhbnNmZXJJdGVtIHtcbiAga2luZDogc3RyaW5nO1xuICB0eXBlOiBzdHJpbmc7XG59XG5cbmludGVyZmFjZSBVSUVycm9yRXZlbnRBcmdzIGV4dGVuZHMgVUlFdmVudEFyZ3Mge1xuICBtZXNzYWdlOiBzdHJpbmc7XG4gIGZpbGVuYW1lOiBzdHJpbmc7XG4gIGxpbmVubzogbnVtYmVyO1xuICBjb2xubzogbnVtYmVyO1xuXG4gIC8vIG9taXR0aW5nICdlcnJvcicgaGVyZSBzaW5jZSB3ZSdkIGhhdmUgdG8gc2VyaWFsaXplIGl0LCBhbmQgaXQncyBub3QgY2xlYXIgd2Ugd2lsbCB3YW50IHRvXG4gIC8vIGRvIHRoYXQuIGh0dHBzOi8vZGV2ZWxvcGVyLm1vemlsbGEub3JnL2VuLVVTL2RvY3MvV2ViL0FQSS9FcnJvckV2ZW50XG59XG5cbmludGVyZmFjZSBVSUZvY3VzRXZlbnRBcmdzIGV4dGVuZHMgVUlFdmVudEFyZ3Mge1xufVxuXG5pbnRlcmZhY2UgVUlLZXlib2FyZEV2ZW50QXJncyBleHRlbmRzIFVJRXZlbnRBcmdzIHtcbiAga2V5OiBzdHJpbmc7XG4gIGNvZGU6IHN0cmluZztcbiAgbG9jYXRpb246IG51bWJlcjtcbiAgcmVwZWF0OiBib29sZWFuO1xuICBjdHJsS2V5OiBib29sZWFuO1xuICBzaGlmdEtleTogYm9vbGVhbjtcbiAgYWx0S2V5OiBib29sZWFuO1xuICBtZXRhS2V5OiBib29sZWFuO1xufVxuXG5pbnRlcmZhY2UgVUlNb3VzZUV2ZW50QXJncyBleHRlbmRzIFVJRXZlbnRBcmdzIHtcbiAgZGV0YWlsOiBudW1iZXI7XG4gIHNjcmVlblg6IG51bWJlcjtcbiAgc2NyZWVuWTogbnVtYmVyO1xuICBjbGllbnRYOiBudW1iZXI7XG4gIGNsaWVudFk6IG51bWJlcjtcbiAgYnV0dG9uOiBudW1iZXI7XG4gIGJ1dHRvbnM6IG51bWJlcjtcbiAgY3RybEtleTogYm9vbGVhbjtcbiAgc2hpZnRLZXk6IGJvb2xlYW47XG4gIGFsdEtleTogYm9vbGVhbjtcbiAgbWV0YUtleTogYm9vbGVhbjtcbn1cblxuaW50ZXJmYWNlIFVJUG9pbnRlckV2ZW50QXJncyBleHRlbmRzIFVJTW91c2VFdmVudEFyZ3Mge1xuICBwb2ludGVySWQ6IG51bWJlcjtcbiAgd2lkdGg6IG51bWJlcjtcbiAgaGVpZ2h0OiBudW1iZXI7XG4gIHByZXNzdXJlOiBudW1iZXI7XG4gIHRpbHRYOiBudW1iZXI7XG4gIHRpbHRZOiBudW1iZXI7XG4gIHBvaW50ZXJUeXBlOiBzdHJpbmc7XG4gIGlzUHJpbWFyeTogYm9vbGVhbjtcbn1cblxuaW50ZXJmYWNlIFVJUHJvZ3Jlc3NFdmVudEFyZ3MgZXh0ZW5kcyBVSUV2ZW50QXJncyB7XG4gIGxlbmd0aENvbXB1dGFibGU6IGJvb2xlYW47XG4gIGxvYWRlZDogbnVtYmVyO1xuICB0b3RhbDogbnVtYmVyO1xufVxuXG5pbnRlcmZhY2UgVUlUb3VjaEV2ZW50QXJncyBleHRlbmRzIFVJRXZlbnRBcmdzIHtcbiAgZGV0YWlsOiBudW1iZXI7XG4gIHRvdWNoZXM6IFVJVG91Y2hQb2ludFtdO1xuICB0YXJnZXRUb3VjaGVzOiBVSVRvdWNoUG9pbnRbXTtcbiAgY2hhbmdlZFRvdWNoZXM6IFVJVG91Y2hQb2ludFtdO1xuICBjdHJsS2V5OiBib29sZWFuO1xuICBzaGlmdEtleTogYm9vbGVhbjtcbiAgYWx0S2V5OiBib29sZWFuO1xuICBtZXRhS2V5OiBib29sZWFuO1xufVxuXG5pbnRlcmZhY2UgVUlUb3VjaFBvaW50IHtcbiAgaWRlbnRpZmllcjogbnVtYmVyO1xuICBzY3JlZW5YOiBudW1iZXI7XG4gIHNjcmVlblk6IG51bWJlcjtcbiAgY2xpZW50WDogbnVtYmVyO1xuICBjbGllbnRZOiBudW1iZXI7XG4gIHBhZ2VYOiBudW1iZXI7XG4gIHBhZ2VZOiBudW1iZXI7XG59XG5cbmludGVyZmFjZSBVSVdoZWVsRXZlbnRBcmdzIGV4dGVuZHMgVUlNb3VzZUV2ZW50QXJncyB7XG4gIGRlbHRhWDogbnVtYmVyO1xuICBkZWx0YVk6IG51bWJlcjtcbiAgZGVsdGFaOiBudW1iZXI7XG4gIGRlbHRhTW9kZTogbnVtYmVyO1xufVxuIiwiLypcbiAgQSBMb2dpY2FsRWxlbWVudCBwbGF5cyB0aGUgc2FtZSByb2xlIGFzIGFuIEVsZW1lbnQgaW5zdGFuY2UgZnJvbSB0aGUgcG9pbnQgb2YgdmlldyBvZiB0aGVcbiAgQVBJIGNvbnN1bWVyLiBJbnNlcnRpbmcgYW5kIHJlbW92aW5nIGxvZ2ljYWwgZWxlbWVudHMgdXBkYXRlcyB0aGUgYnJvd3NlciBET00ganVzdCB0aGUgc2FtZS5cblxuICBUaGUgZGlmZmVyZW5jZSBpcyB0aGF0LCB1bmxpa2UgcmVndWxhciBET00gbXV0YXRpb24gQVBJcywgdGhlIExvZ2ljYWxFbGVtZW50IEFQSXMgZG9uJ3QgdXNlXG4gIHRoZSB1bmRlcmx5aW5nIERPTSBzdHJ1Y3R1cmUgYXMgdGhlIGRhdGEgc3RvcmFnZSBmb3IgdGhlIGVsZW1lbnQgaGllcmFyY2h5LiBJbnN0ZWFkLCB0aGVcbiAgTG9naWNhbEVsZW1lbnQgQVBJcyB0YWtlIGNhcmUgb2YgdHJhY2tpbmcgaGllcmFyY2hpY2FsIHJlbGF0aW9uc2hpcHMgc2VwYXJhdGVseS4gVGhlIHBvaW50XG4gIG9mIHRoaXMgaXMgdG8gcGVybWl0IGEgbG9naWNhbCB0cmVlIHN0cnVjdHVyZSBpbiB3aGljaCBwYXJlbnQvY2hpbGQgcmVsYXRpb25zaGlwcyBkb24ndFxuICBoYXZlIHRvIGJlIG1hdGVyaWFsaXplZCBpbiB0ZXJtcyBvZiBET00gZWxlbWVudCBwYXJlbnQvY2hpbGQgcmVsYXRpb25zaGlwcy4gQW5kIHRoZSByZWFzb25cbiAgd2h5IHdlIHdhbnQgdGhhdCBpcyBzbyB0aGF0IGhpZXJhcmNoaWVzIG9mIEJsYXpvciBjb21wb25lbnRzIGNhbiBiZSB0cmFja2VkIGV2ZW4gd2hlbiB0aG9zZVxuICBjb21wb25lbnRzJyByZW5kZXIgb3V0cHV0IG5lZWQgbm90IGJlIGEgc2luZ2xlIGxpdGVyYWwgRE9NIGVsZW1lbnQuXG5cbiAgQ29uc3VtZXJzIG9mIHRoZSBBUEkgZG9uJ3QgbmVlZCB0byBrbm93IGFib3V0IHRoZSBpbXBsZW1lbnRhdGlvbiwgYnV0IGhvdyBpdCdzIGRvbmUgaXM6XG4gIC0gRWFjaCBMb2dpY2FsRWxlbWVudCBpcyBtYXRlcmlhbGl6ZWQgaW4gdGhlIERPTSBhcyBlaXRoZXI6XG4gICAgLSBBIE5vZGUgaW5zdGFuY2UsIGZvciBhY3R1YWwgTm9kZSBpbnN0YW5jZXMgaW5zZXJ0ZWQgdXNpbmcgJ2luc2VydExvZ2ljYWxDaGlsZCcgb3JcbiAgICAgIGZvciBFbGVtZW50IGluc3RhbmNlcyBwcm9tb3RlZCB0byBMb2dpY2FsRWxlbWVudCB2aWEgJ3RvTG9naWNhbEVsZW1lbnQnXG4gICAgLSBBIENvbW1lbnQgaW5zdGFuY2UsIGZvciAnbG9naWNhbCBjb250YWluZXInIGluc3RhbmNlcyBpbnNlcnRlZCB1c2luZyAnY3JlYXRlQW5kSW5zZXJ0TG9naWNhbENvbnRhaW5lcidcbiAgLSBUaGVuLCBvbiB0aGF0IGluc3RhbmNlIChpLmUuLCB0aGUgTm9kZSBvciBDb21tZW50KSwgd2Ugc3RvcmUgYW4gYXJyYXkgb2YgJ2xvZ2ljYWwgY2hpbGRyZW4nXG4gICAgaW5zdGFuY2VzLCBlLmcuLFxuICAgICAgW2ZpcnN0Q2hpbGQsIHNlY29uZENoaWxkLCB0aGlyZENoaWxkLCAuLi5dXG4gICAgLi4uIHBsdXMgd2Ugc3RvcmUgYSByZWZlcmVuY2UgdG8gdGhlICdsb2dpY2FsIHBhcmVudCcgKGlmIGFueSlcbiAgLSBUaGUgJ2xvZ2ljYWwgY2hpbGRyZW4nIGFycmF5IG1lYW5zIHdlIGNhbiBsb29rIHVwIGluIE8oMSk6XG4gICAgLSBUaGUgbnVtYmVyIG9mIGxvZ2ljYWwgY2hpbGRyZW4gKG5vdCBjdXJyZW50bHkgaW1wbGVtZW50ZWQgYmVjYXVzZSBub3QgcmVxdWlyZWQsIGJ1dCB0cml2aWFsKVxuICAgIC0gVGhlIGxvZ2ljYWwgY2hpbGQgYXQgYW55IGdpdmVuIGluZGV4XG4gIC0gV2hlbmV2ZXIgYSBsb2dpY2FsIGNoaWxkIGlzIGFkZGVkIG9yIHJlbW92ZWQsIHdlIHVwZGF0ZSB0aGUgcGFyZW50J3MgYXJyYXkgb2YgbG9naWNhbCBjaGlsZHJlblxuKi9cblxuY29uc3QgbG9naWNhbENoaWxkcmVuUHJvcG5hbWUgPSBjcmVhdGVTeW1ib2xPckZhbGxiYWNrKCdfYmxhem9yTG9naWNhbENoaWxkcmVuJyk7XG5jb25zdCBsb2dpY2FsUGFyZW50UHJvcG5hbWUgPSBjcmVhdGVTeW1ib2xPckZhbGxiYWNrKCdfYmxhem9yTG9naWNhbFBhcmVudCcpO1xuXG5leHBvcnQgZnVuY3Rpb24gdG9Mb2dpY2FsRWxlbWVudChlbGVtZW50OiBFbGVtZW50LCBhbGxvd0V4aXN0aW5nQ29udGVudHM/OiBib29sZWFuKSB7XG4gIC8vIE5vcm1hbGx5IGl0J3MgZ29vZCB0byBhc3NlcnQgdGhhdCB0aGUgZWxlbWVudCBoYXMgc3RhcnRlZCBlbXB0eSwgYmVjYXVzZSB0aGF0J3MgdGhlIHVzdWFsXG4gIC8vIHNpdHVhdGlvbiBhbmQgd2UgcHJvYmFibHkgaGF2ZSBhIGJ1ZyBpZiBpdCdzIG5vdC4gQnV0IGZvciB0aGUgZWxlbWVudCB0aGF0IGNvbnRhaW4gcHJlcmVuZGVyZWRcbiAgLy8gcm9vdCBjb21wb25lbnRzLCB3ZSB3YW50IHRvIGxldCB0aGVtIGtlZXAgdGhlaXIgY29udGVudCB1bnRpbCB3ZSByZXBsYWNlIGl0LlxuICBpZiAoZWxlbWVudC5jaGlsZE5vZGVzLmxlbmd0aCA+IDAgJiYgIWFsbG93RXhpc3RpbmdDb250ZW50cykge1xuICAgIHRocm93IG5ldyBFcnJvcignTmV3IGxvZ2ljYWwgZWxlbWVudHMgbXVzdCBzdGFydCBlbXB0eSwgb3IgYWxsb3dFeGlzdGluZ0NvbnRlbnRzIG11c3QgYmUgdHJ1ZScpO1xuICB9XG5cbiAgZWxlbWVudFtsb2dpY2FsQ2hpbGRyZW5Qcm9wbmFtZV0gPSBbXTtcbiAgcmV0dXJuIGVsZW1lbnQgYXMgYW55IGFzIExvZ2ljYWxFbGVtZW50O1xufVxuXG5leHBvcnQgZnVuY3Rpb24gY3JlYXRlQW5kSW5zZXJ0TG9naWNhbENvbnRhaW5lcihwYXJlbnQ6IExvZ2ljYWxFbGVtZW50LCBjaGlsZEluZGV4OiBudW1iZXIpOiBMb2dpY2FsRWxlbWVudCB7XG4gIGNvbnN0IGNvbnRhaW5lckVsZW1lbnQgPSBkb2N1bWVudC5jcmVhdGVDb21tZW50KCchJyk7XG4gIGluc2VydExvZ2ljYWxDaGlsZChjb250YWluZXJFbGVtZW50LCBwYXJlbnQsIGNoaWxkSW5kZXgpO1xuICByZXR1cm4gY29udGFpbmVyRWxlbWVudCBhcyBhbnkgYXMgTG9naWNhbEVsZW1lbnQ7XG59XG5cbmV4cG9ydCBmdW5jdGlvbiBpbnNlcnRMb2dpY2FsQ2hpbGQoY2hpbGQ6IE5vZGUsIHBhcmVudDogTG9naWNhbEVsZW1lbnQsIGNoaWxkSW5kZXg6IG51bWJlcikge1xuICBjb25zdCBjaGlsZEFzTG9naWNhbEVsZW1lbnQgPSBjaGlsZCBhcyBhbnkgYXMgTG9naWNhbEVsZW1lbnQ7XG4gIGlmIChjaGlsZCBpbnN0YW5jZW9mIENvbW1lbnQpIHtcbiAgICBjb25zdCBleGlzdGluZ0dyYW5kY2hpbGRyZW4gPSBnZXRMb2dpY2FsQ2hpbGRyZW5BcnJheShjaGlsZEFzTG9naWNhbEVsZW1lbnQpO1xuICAgIGlmIChleGlzdGluZ0dyYW5kY2hpbGRyZW4gJiYgZ2V0TG9naWNhbENoaWxkcmVuQXJyYXkoY2hpbGRBc0xvZ2ljYWxFbGVtZW50KS5sZW5ndGggPiAwKSB7XG4gICAgICAvLyBUaGVyZSdzIG5vdGhpbmcgdG8gc3RvcCB1cyBpbXBsZW1lbnRpbmcgc3VwcG9ydCBmb3IgdGhpcyBzY2VuYXJpbywgYW5kIGl0J3Mgbm90IGRpZmZpY3VsdFxuICAgICAgLy8gKGFmdGVyIGluc2VydGluZyAnY2hpbGQnIGl0c2VsZiwgYWxzbyBpdGVyYXRlIHRocm91Z2ggaXRzIGxvZ2ljYWwgY2hpbGRyZW4gYW5kIHBoeXNpY2FsbHlcbiAgICAgIC8vIHB1dCB0aGVtIGFzIGZvbGxvd2luZy1zaWJsaW5ncyBpbiB0aGUgRE9NKS4gSG93ZXZlciB0aGVyZSdzIG5vIHNjZW5hcmlvIHRoYXQgcmVxdWlyZXMgaXRcbiAgICAgIC8vIHByZXNlbnRseSwgc28gaWYgd2UgZGlkIGltcGxlbWVudCBpdCB0aGVyZSdkIGJlIG5vIGdvb2Qgd2F5IHRvIGhhdmUgdGVzdHMgZm9yIGl0LlxuICAgICAgdGhyb3cgbmV3IEVycm9yKCdOb3QgaW1wbGVtZW50ZWQ6IGluc2VydGluZyBub24tZW1wdHkgbG9naWNhbCBjb250YWluZXInKTtcbiAgICB9XG4gIH1cblxuICBpZiAoZ2V0TG9naWNhbFBhcmVudChjaGlsZEFzTG9naWNhbEVsZW1lbnQpKSB7XG4gICAgLy8gTGlrZXdpc2UsIHdlIGNvdWxkIGVhc2lseSBzdXBwb3J0IHRoaXMgc2NlbmFyaW8gdG9vIChpbiB0aGlzICdpZicgYmxvY2ssIGp1c3Qgc3BsaWNlXG4gICAgLy8gb3V0ICdjaGlsZCcgZnJvbSB0aGUgbG9naWNhbCBjaGlsZHJlbiBhcnJheSBvZiBpdHMgcHJldmlvdXMgbG9naWNhbCBwYXJlbnQgYnkgdXNpbmdcbiAgICAvLyBBcnJheS5wcm90b3R5cGUuaW5kZXhPZiB0byBkZXRlcm1pbmUgaXRzIHByZXZpb3VzIHNpYmxpbmcgaW5kZXgpLlxuICAgIC8vIEJ1dCBhZ2Fpbiwgc2luY2UgdGhlcmUncyBub3QgY3VycmVudGx5IGFueSBzY2VuYXJpbyB0aGF0IHdvdWxkIHVzZSBpdCwgd2Ugd291bGQgbm90XG4gICAgLy8gaGF2ZSBhbnkgdGVzdCBjb3ZlcmFnZSBmb3Igc3VjaCBhbiBpbXBsZW1lbnRhdGlvbi5cbiAgICB0aHJvdyBuZXcgRXJyb3IoJ05vdCBpbXBsZW1lbnRlZDogbW92aW5nIGV4aXN0aW5nIGxvZ2ljYWwgY2hpbGRyZW4nKTtcbiAgfVxuXG4gIGNvbnN0IG5ld1NpYmxpbmdzID0gZ2V0TG9naWNhbENoaWxkcmVuQXJyYXkocGFyZW50KTtcbiAgaWYgKGNoaWxkSW5kZXggPCBuZXdTaWJsaW5ncy5sZW5ndGgpIHtcbiAgICAvLyBJbnNlcnRcbiAgICBjb25zdCBuZXh0U2libGluZyA9IG5ld1NpYmxpbmdzW2NoaWxkSW5kZXhdIGFzIGFueSBhcyBOb2RlO1xuICAgIG5leHRTaWJsaW5nLnBhcmVudE5vZGUhLmluc2VydEJlZm9yZShjaGlsZCwgbmV4dFNpYmxpbmcpO1xuICAgIG5ld1NpYmxpbmdzLnNwbGljZShjaGlsZEluZGV4LCAwLCBjaGlsZEFzTG9naWNhbEVsZW1lbnQpO1xuICB9IGVsc2Uge1xuICAgIC8vIEFwcGVuZFxuICAgIGFwcGVuZERvbU5vZGUoY2hpbGQsIHBhcmVudCk7XG4gICAgbmV3U2libGluZ3MucHVzaChjaGlsZEFzTG9naWNhbEVsZW1lbnQpO1xuICB9XG5cbiAgY2hpbGRBc0xvZ2ljYWxFbGVtZW50W2xvZ2ljYWxQYXJlbnRQcm9wbmFtZV0gPSBwYXJlbnQ7XG4gIGlmICghKGxvZ2ljYWxDaGlsZHJlblByb3BuYW1lIGluIGNoaWxkQXNMb2dpY2FsRWxlbWVudCkpIHtcbiAgICBjaGlsZEFzTG9naWNhbEVsZW1lbnRbbG9naWNhbENoaWxkcmVuUHJvcG5hbWVdID0gW107XG4gIH1cbn1cblxuZXhwb3J0IGZ1bmN0aW9uIHJlbW92ZUxvZ2ljYWxDaGlsZChwYXJlbnQ6IExvZ2ljYWxFbGVtZW50LCBjaGlsZEluZGV4OiBudW1iZXIpIHtcbiAgY29uc3QgY2hpbGRyZW5BcnJheSA9IGdldExvZ2ljYWxDaGlsZHJlbkFycmF5KHBhcmVudCk7XG4gIGNvbnN0IGNoaWxkVG9SZW1vdmUgPSBjaGlsZHJlbkFycmF5LnNwbGljZShjaGlsZEluZGV4LCAxKVswXTtcblxuICAvLyBJZiBpdCdzIGEgbG9naWNhbCBjb250YWluZXIsIGFsc28gcmVtb3ZlIGl0cyBkZXNjZW5kYW50c1xuICBpZiAoY2hpbGRUb1JlbW92ZSBpbnN0YW5jZW9mIENvbW1lbnQpIHtcbiAgICBjb25zdCBncmFuZGNoaWxkcmVuQXJyYXkgPSBnZXRMb2dpY2FsQ2hpbGRyZW5BcnJheShjaGlsZFRvUmVtb3ZlKTtcbiAgICB3aGlsZSAoZ3JhbmRjaGlsZHJlbkFycmF5Lmxlbmd0aCA+IDApIHtcbiAgICAgIHJlbW92ZUxvZ2ljYWxDaGlsZChjaGlsZFRvUmVtb3ZlLCAwKTtcbiAgICB9XG4gIH1cblxuICAvLyBGaW5hbGx5LCByZW1vdmUgdGhlIG5vZGUgaXRzZWxmXG4gIGNvbnN0IGRvbU5vZGVUb1JlbW92ZSA9IGNoaWxkVG9SZW1vdmUgYXMgYW55IGFzIE5vZGU7XG4gIGRvbU5vZGVUb1JlbW92ZS5wYXJlbnROb2RlIS5yZW1vdmVDaGlsZChkb21Ob2RlVG9SZW1vdmUpO1xufVxuXG5leHBvcnQgZnVuY3Rpb24gZ2V0TG9naWNhbFBhcmVudChlbGVtZW50OiBMb2dpY2FsRWxlbWVudCk6IExvZ2ljYWxFbGVtZW50IHwgbnVsbCB7XG4gIHJldHVybiAoZWxlbWVudFtsb2dpY2FsUGFyZW50UHJvcG5hbWVdIGFzIExvZ2ljYWxFbGVtZW50KSB8fCBudWxsO1xufVxuXG5leHBvcnQgZnVuY3Rpb24gZ2V0TG9naWNhbENoaWxkKHBhcmVudDogTG9naWNhbEVsZW1lbnQsIGNoaWxkSW5kZXg6IG51bWJlcik6IExvZ2ljYWxFbGVtZW50IHtcbiAgcmV0dXJuIGdldExvZ2ljYWxDaGlsZHJlbkFycmF5KHBhcmVudClbY2hpbGRJbmRleF07XG59XG5cbmV4cG9ydCBmdW5jdGlvbiBpc1N2Z0VsZW1lbnQoZWxlbWVudDogTG9naWNhbEVsZW1lbnQpIHtcbiAgcmV0dXJuIGdldENsb3Nlc3REb21FbGVtZW50KGVsZW1lbnQpLm5hbWVzcGFjZVVSSSA9PT0gJ2h0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnJztcbn1cblxuZnVuY3Rpb24gZ2V0TG9naWNhbENoaWxkcmVuQXJyYXkoZWxlbWVudDogTG9naWNhbEVsZW1lbnQpIHtcbiAgcmV0dXJuIGVsZW1lbnRbbG9naWNhbENoaWxkcmVuUHJvcG5hbWVdIGFzIExvZ2ljYWxFbGVtZW50W107XG59XG5cbmZ1bmN0aW9uIGdldExvZ2ljYWxOZXh0U2libGluZyhlbGVtZW50OiBMb2dpY2FsRWxlbWVudCk6IExvZ2ljYWxFbGVtZW50IHwgbnVsbCB7XG4gIGNvbnN0IHNpYmxpbmdzID0gZ2V0TG9naWNhbENoaWxkcmVuQXJyYXkoZ2V0TG9naWNhbFBhcmVudChlbGVtZW50KSEpO1xuICBjb25zdCBzaWJsaW5nSW5kZXggPSBBcnJheS5wcm90b3R5cGUuaW5kZXhPZi5jYWxsKHNpYmxpbmdzLCBlbGVtZW50KTtcbiAgcmV0dXJuIHNpYmxpbmdzW3NpYmxpbmdJbmRleCArIDFdIHx8IG51bGw7XG59XG5cbmZ1bmN0aW9uIGdldENsb3Nlc3REb21FbGVtZW50KGxvZ2ljYWxFbGVtZW50OiBMb2dpY2FsRWxlbWVudCkge1xuICBpZiAobG9naWNhbEVsZW1lbnQgaW5zdGFuY2VvZiBFbGVtZW50KSB7XG4gICAgcmV0dXJuIGxvZ2ljYWxFbGVtZW50O1xuICB9IGVsc2UgaWYgKGxvZ2ljYWxFbGVtZW50IGluc3RhbmNlb2YgQ29tbWVudCkge1xuICAgIHJldHVybiBsb2dpY2FsRWxlbWVudC5wYXJlbnROb2RlISBhcyBFbGVtZW50O1xuICB9IGVsc2Uge1xuICAgIHRocm93IG5ldyBFcnJvcignTm90IGEgdmFsaWQgbG9naWNhbCBlbGVtZW50Jyk7XG4gIH1cbn1cblxuZnVuY3Rpb24gYXBwZW5kRG9tTm9kZShjaGlsZDogTm9kZSwgcGFyZW50OiBMb2dpY2FsRWxlbWVudCkge1xuICAvLyBUaGlzIGZ1bmN0aW9uIG9ubHkgcHV0cyAnY2hpbGQnIGludG8gdGhlIERPTSBpbiB0aGUgcmlnaHQgcGxhY2UgcmVsYXRpdmUgdG8gJ3BhcmVudCdcbiAgLy8gSXQgZG9lcyBub3QgdXBkYXRlIHRoZSBsb2dpY2FsIGNoaWxkcmVuIGFycmF5IG9mIGFueXRoaW5nXG4gIGlmIChwYXJlbnQgaW5zdGFuY2VvZiBFbGVtZW50KSB7XG4gICAgcGFyZW50LmFwcGVuZENoaWxkKGNoaWxkKTtcbiAgfSBlbHNlIGlmIChwYXJlbnQgaW5zdGFuY2VvZiBDb21tZW50KSB7XG4gICAgY29uc3QgcGFyZW50TG9naWNhbE5leHRTaWJsaW5nID0gZ2V0TG9naWNhbE5leHRTaWJsaW5nKHBhcmVudCkgYXMgYW55IGFzIE5vZGU7XG4gICAgaWYgKHBhcmVudExvZ2ljYWxOZXh0U2libGluZykge1xuICAgICAgLy8gU2luY2UgdGhlIHBhcmVudCBoYXMgYSBsb2dpY2FsIG5leHQtc2libGluZywgaXRzIGFwcGVuZGVkIGNoaWxkIGdvZXMgcmlnaHQgYmVmb3JlIHRoYXRcbiAgICAgIHBhcmVudExvZ2ljYWxOZXh0U2libGluZy5wYXJlbnROb2RlIS5pbnNlcnRCZWZvcmUoY2hpbGQsIHBhcmVudExvZ2ljYWxOZXh0U2libGluZyk7XG4gICAgfSBlbHNlIHtcbiAgICAgIC8vIFNpbmNlIHRoZSBwYXJlbnQgaGFzIG5vIGxvZ2ljYWwgbmV4dC1zaWJsaW5nLCBrZWVwIHJlY3Vyc2luZyB1cHdhcmRzIHVudGlsIHdlIGZpbmRcbiAgICAgIC8vIGEgbG9naWNhbCBhbmNlc3RvciB0aGF0IGRvZXMgaGF2ZSBhIG5leHQtc2libGluZyBvciBpcyBhIHBoeXNpY2FsIGVsZW1lbnQuXG4gICAgICBhcHBlbmREb21Ob2RlKGNoaWxkLCBnZXRMb2dpY2FsUGFyZW50KHBhcmVudCkhKTtcbiAgICB9XG4gIH0gZWxzZSB7XG4gICAgLy8gU2hvdWxkIG5ldmVyIGhhcHBlblxuICAgIHRocm93IG5ldyBFcnJvcihgQ2Fubm90IGFwcGVuZCBub2RlIGJlY2F1c2UgdGhlIHBhcmVudCBpcyBub3QgYSB2YWxpZCBsb2dpY2FsIGVsZW1lbnQuIFBhcmVudDogJHtwYXJlbnR9YCk7XG4gIH1cbn1cblxuZnVuY3Rpb24gY3JlYXRlU3ltYm9sT3JGYWxsYmFjayhmYWxsYmFjazogc3RyaW5nKTogc3ltYm9sIHwgc3RyaW5nIHtcbiAgcmV0dXJuIHR5cGVvZiBTeW1ib2wgPT09ICdmdW5jdGlvbicgPyBTeW1ib2woKSA6IGZhbGxiYWNrO1xufVxuXG4vLyBOb21pbmFsIHR5cGUgdG8gcmVwcmVzZW50IGEgbG9naWNhbCBlbGVtZW50IHdpdGhvdXQgbmVlZGluZyB0byBhbGxvY2F0ZSBhbnkgb2JqZWN0IGZvciBpbnN0YW5jZXNcbmV4cG9ydCBpbnRlcmZhY2UgTG9naWNhbEVsZW1lbnQgeyBMb2dpY2FsRWxlbWVudF9fRE9fTk9UX0lNUExFTUVOVDogYW55IH07XG4iLCJleHBvcnQgaW50ZXJmYWNlIFJlbmRlckJhdGNoIHtcbiAgdXBkYXRlZENvbXBvbmVudHMoKTogQXJyYXlSYW5nZTxSZW5kZXJUcmVlRGlmZj47XG4gIHJlZmVyZW5jZUZyYW1lcygpOiBBcnJheVJhbmdlPFJlbmRlclRyZWVGcmFtZT47XG4gIGRpc3Bvc2VkQ29tcG9uZW50SWRzKCk6IEFycmF5UmFuZ2U8bnVtYmVyPjtcbiAgZGlzcG9zZWRFdmVudEhhbmRsZXJJZHMoKTogQXJyYXlSYW5nZTxudW1iZXI+O1xuXG4gIHVwZGF0ZWRDb21wb25lbnRzRW50cnkodmFsdWVzOiBBcnJheVZhbHVlczxSZW5kZXJUcmVlRGlmZj4sIGluZGV4OiBudW1iZXIpOiBSZW5kZXJUcmVlRGlmZjtcbiAgcmVmZXJlbmNlRnJhbWVzRW50cnkodmFsdWVzOiBBcnJheVZhbHVlczxSZW5kZXJUcmVlRnJhbWU+LCBpbmRleDogbnVtYmVyKTogUmVuZGVyVHJlZUZyYW1lO1xuICBkaXNwb3NlZENvbXBvbmVudElkc0VudHJ5KHZhbHVlczogQXJyYXlWYWx1ZXM8bnVtYmVyPiwgaW5kZXg6IG51bWJlcik6IG51bWJlcjtcbiAgZGlzcG9zZWRFdmVudEhhbmRsZXJJZHNFbnRyeSh2YWx1ZXM6IEFycmF5VmFsdWVzPG51bWJlcj4sIGluZGV4OiBudW1iZXIpOiBudW1iZXI7XG5cbiAgZGlmZlJlYWRlcjogUmVuZGVyVHJlZURpZmZSZWFkZXI7XG4gIGVkaXRSZWFkZXI6IFJlbmRlclRyZWVFZGl0UmVhZGVyO1xuICBmcmFtZVJlYWRlcjogUmVuZGVyVHJlZUZyYW1lUmVhZGVyO1xuICBhcnJheVJhbmdlUmVhZGVyOiBBcnJheVJhbmdlUmVhZGVyO1xuICBhcnJheVNlZ21lbnRSZWFkZXI6IEFycmF5U2VnbWVudFJlYWRlcjtcbn1cblxuZXhwb3J0IGludGVyZmFjZSBBcnJheVJhbmdlUmVhZGVyIHtcbiAgY291bnQ8VD4oYXJyYXlSYW5nZTogQXJyYXlSYW5nZTxUPik6IG51bWJlcjtcbiAgdmFsdWVzPFQ+KGFycmF5UmFuZ2U6IEFycmF5UmFuZ2U8VD4pOiBBcnJheVZhbHVlczxUPjtcbn1cblxuZXhwb3J0IGludGVyZmFjZSBBcnJheVNlZ21lbnRSZWFkZXIge1xuICBvZmZzZXQ8VD4oYXJyYXlTZWdtZW50OiBBcnJheVNlZ21lbnQ8VD4pOiBudW1iZXI7XG4gIGNvdW50PFQ+KGFycmF5U2VnbWVudDogQXJyYXlTZWdtZW50PFQ+KTogbnVtYmVyO1xuICB2YWx1ZXM8VD4oYXJyYXlTZWdtZW50OiBBcnJheVNlZ21lbnQ8VD4pOiBBcnJheVZhbHVlczxUPjtcbn1cblxuZXhwb3J0IGludGVyZmFjZSBSZW5kZXJUcmVlRGlmZlJlYWRlciB7XG4gIGNvbXBvbmVudElkKGRpZmY6IFJlbmRlclRyZWVEaWZmKTogbnVtYmVyO1xuICBlZGl0cyhkaWZmOiBSZW5kZXJUcmVlRGlmZik6IEFycmF5U2VnbWVudDxSZW5kZXJUcmVlRWRpdD47XG4gIGVkaXRzRW50cnkodmFsdWVzOiBBcnJheVZhbHVlczxSZW5kZXJUcmVlRWRpdD4sIGluZGV4OiBudW1iZXIpOiBSZW5kZXJUcmVlRWRpdDtcbn1cblxuZXhwb3J0IGludGVyZmFjZSBSZW5kZXJUcmVlRWRpdFJlYWRlciB7XG4gIGVkaXRUeXBlKGVkaXQ6IFJlbmRlclRyZWVFZGl0KTogRWRpdFR5cGU7XG4gIHNpYmxpbmdJbmRleChlZGl0OiBSZW5kZXJUcmVlRWRpdCk6IG51bWJlcjtcbiAgbmV3VHJlZUluZGV4KGVkaXQ6IFJlbmRlclRyZWVFZGl0KTogbnVtYmVyO1xuICByZW1vdmVkQXR0cmlidXRlTmFtZShlZGl0OiBSZW5kZXJUcmVlRWRpdCk6IHN0cmluZyB8IG51bGw7XG59XG5cbmV4cG9ydCBpbnRlcmZhY2UgUmVuZGVyVHJlZUZyYW1lUmVhZGVyIHtcbiAgZnJhbWVUeXBlKGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpOiBGcmFtZVR5cGU7XG4gIHN1YnRyZWVMZW5ndGgoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSk6IG51bWJlcjtcbiAgZWxlbWVudFJlZmVyZW5jZUNhcHR1cmVJZChmcmFtZTogUmVuZGVyVHJlZUZyYW1lKTogc3RyaW5nIHwgbnVsbDtcbiAgY29tcG9uZW50SWQoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSk6IG51bWJlcjtcbiAgZWxlbWVudE5hbWUoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSk6IHN0cmluZyB8IG51bGw7XG4gIHRleHRDb250ZW50KGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpOiBzdHJpbmcgfCBudWxsO1xuICBtYXJrdXBDb250ZW50KGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpOiBzdHJpbmc7XG4gIGF0dHJpYnV0ZU5hbWUoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSk6IHN0cmluZyB8IG51bGw7XG4gIGF0dHJpYnV0ZVZhbHVlKGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpOiBzdHJpbmcgfCBudWxsO1xuICBhdHRyaWJ1dGVFdmVudEhhbmRsZXJJZChmcmFtZTogUmVuZGVyVHJlZUZyYW1lKTogbnVtYmVyO1xufVxuXG5leHBvcnQgaW50ZXJmYWNlIEFycmF5UmFuZ2U8VD4geyBBcnJheVJhbmdlX19ET19OT1RfSU1QTEVNRU5UOiBhbnkgfVxuZXhwb3J0IGludGVyZmFjZSBBcnJheVNlZ21lbnQ8VD4geyBBcnJheVNlZ21lbnRfX0RPX05PVF9JTVBMRU1FTlQ6IGFueSB9XG5leHBvcnQgaW50ZXJmYWNlIEFycmF5VmFsdWVzPFQ+IHsgQXJyYXlWYWx1ZXNfX0RPX05PVF9JTVBMRU1FTlQ6IGFueSB9XG5cbmV4cG9ydCBpbnRlcmZhY2UgUmVuZGVyVHJlZURpZmYgeyBSZW5kZXJUcmVlRGlmZl9fRE9fTk9UX0lNUExFTUVOVDogYW55IH1cbmV4cG9ydCBpbnRlcmZhY2UgUmVuZGVyVHJlZUZyYW1lIHsgUmVuZGVyVHJlZUZyYW1lX19ET19OT1RfSU1QTEVNRU5UOiBhbnkgfVxuZXhwb3J0IGludGVyZmFjZSBSZW5kZXJUcmVlRWRpdCB7IFJlbmRlclRyZWVFZGl0X19ET19OT1RfSU1QTEVNRU5UOiBhbnkgfVxuXG5leHBvcnQgZW51bSBFZGl0VHlwZSB7XG4gIC8vIFRoZSB2YWx1ZXMgbXVzdCBiZSBrZXB0IGluIHN5bmMgd2l0aCB0aGUgLk5FVCBlcXVpdmFsZW50IGluIFJlbmRlclRyZWVFZGl0VHlwZS5jc1xuICBwcmVwZW5kRnJhbWUgPSAxLFxuICByZW1vdmVGcmFtZSA9IDIsXG4gIHNldEF0dHJpYnV0ZSA9IDMsXG4gIHJlbW92ZUF0dHJpYnV0ZSA9IDQsXG4gIHVwZGF0ZVRleHQgPSA1LFxuICBzdGVwSW4gPSA2LFxuICBzdGVwT3V0ID0gNyxcbiAgdXBkYXRlTWFya3VwID0gOCxcbn1cblxuZXhwb3J0IGVudW0gRnJhbWVUeXBlIHtcbiAgLy8gVGhlIHZhbHVlcyBtdXN0IGJlIGtlcHQgaW4gc3luYyB3aXRoIHRoZSAuTkVUIGVxdWl2YWxlbnQgaW4gUmVuZGVyVHJlZUZyYW1lVHlwZS5jc1xuICBlbGVtZW50ID0gMSxcbiAgdGV4dCA9IDIsXG4gIGF0dHJpYnV0ZSA9IDMsXG4gIGNvbXBvbmVudCA9IDQsXG4gIHJlZ2lvbiA9IDUsXG4gIGVsZW1lbnRSZWZlcmVuY2VDYXB0dXJlID0gNixcbiAgbWFya3VwID0gOCxcbn1cbiIsImltcG9ydCB7IHBsYXRmb3JtIH0gZnJvbSAnLi4vLi4vRW52aXJvbm1lbnQnO1xuaW1wb3J0IHsgUmVuZGVyQmF0Y2gsIEFycmF5UmFuZ2UsIEFycmF5UmFuZ2VSZWFkZXIsIEFycmF5U2VnbWVudCwgUmVuZGVyVHJlZURpZmYsIFJlbmRlclRyZWVFZGl0LCBSZW5kZXJUcmVlRnJhbWUsIEFycmF5VmFsdWVzLCBFZGl0VHlwZSwgRnJhbWVUeXBlLCBSZW5kZXJUcmVlRnJhbWVSZWFkZXIgfSBmcm9tICcuL1JlbmRlckJhdGNoJztcbmltcG9ydCB7IFBvaW50ZXIsIFN5c3RlbV9BcnJheSB9IGZyb20gJy4uLy4uL1BsYXRmb3JtL1BsYXRmb3JtJztcblxuLy8gVXNlZCB3aGVuIHJ1bm5pbmcgb24gTW9ubyBXZWJBc3NlbWJseSBmb3Igc2hhcmVkLW1lbW9yeSBpbnRlcm9wLiBUaGUgY29kZSBoZXJlIGVuY2Fwc3VsYXRlc1xuLy8gb3VyIGtub3dsZWRnZSBvZiB0aGUgbWVtb3J5IGxheW91dCBvZiBSZW5kZXJCYXRjaCBhbmQgYWxsIHJlZmVyZW5jZWQgdHlwZXMuXG4vL1xuLy8gSW4gdGhpcyBpbXBsZW1lbnRhdGlvbiwgYWxsIHRoZSBEVE8gdHlwZXMgYXJlIHJlYWxseSBoZWFwIHBvaW50ZXJzIGF0IHJ1bnRpbWUsIGhlbmNlIGFsbFxuLy8gdGhlIGNhc3RzIHRvICdhbnknIHdoZW5ldmVyIHdlIHBhc3MgdGhlbSB0byBwbGF0Zm9ybS5yZWFkLlxuXG5leHBvcnQgY2xhc3MgU2hhcmVkTWVtb3J5UmVuZGVyQmF0Y2ggaW1wbGVtZW50cyBSZW5kZXJCYXRjaCB7XG4gIGNvbnN0cnVjdG9yKHByaXZhdGUgYmF0Y2hBZGRyZXNzOiBQb2ludGVyKSB7XG4gIH1cblxuICAvLyBLZWVwIGluIHN5bmMgd2l0aCBtZW1vcnkgbGF5b3V0IGluIFJlbmRlckJhdGNoLmNzXG4gIHVwZGF0ZWRDb21wb25lbnRzKCkgeyByZXR1cm4gcGxhdGZvcm0ucmVhZFN0cnVjdEZpZWxkPFBvaW50ZXI+KHRoaXMuYmF0Y2hBZGRyZXNzLCAwKSBhcyBhbnkgYXMgQXJyYXlSYW5nZTxSZW5kZXJUcmVlRGlmZj47IH1cbiAgcmVmZXJlbmNlRnJhbWVzKCkgeyByZXR1cm4gcGxhdGZvcm0ucmVhZFN0cnVjdEZpZWxkPFBvaW50ZXI+KHRoaXMuYmF0Y2hBZGRyZXNzLCBhcnJheVJhbmdlUmVhZGVyLnN0cnVjdExlbmd0aCkgYXMgYW55IGFzIEFycmF5UmFuZ2U8UmVuZGVyVHJlZURpZmY+OyB9XG4gIGRpc3Bvc2VkQ29tcG9uZW50SWRzKCkgeyByZXR1cm4gcGxhdGZvcm0ucmVhZFN0cnVjdEZpZWxkPFBvaW50ZXI+KHRoaXMuYmF0Y2hBZGRyZXNzLCBhcnJheVJhbmdlUmVhZGVyLnN0cnVjdExlbmd0aCAqIDIpIGFzIGFueSBhcyBBcnJheVJhbmdlPG51bWJlcj47IH1cbiAgZGlzcG9zZWRFdmVudEhhbmRsZXJJZHMoKSB7IHJldHVybiBwbGF0Zm9ybS5yZWFkU3RydWN0RmllbGQ8UG9pbnRlcj4odGhpcy5iYXRjaEFkZHJlc3MsIGFycmF5UmFuZ2VSZWFkZXIuc3RydWN0TGVuZ3RoICogMykgYXMgYW55IGFzIEFycmF5UmFuZ2U8bnVtYmVyPjsgfVxuXG4gIHVwZGF0ZWRDb21wb25lbnRzRW50cnkodmFsdWVzOiBBcnJheVZhbHVlczxSZW5kZXJUcmVlRGlmZj4sIGluZGV4OiBudW1iZXIpIHtcbiAgICByZXR1cm4gYXJyYXlWYWx1ZXNFbnRyeSh2YWx1ZXMsIGluZGV4LCBkaWZmUmVhZGVyLnN0cnVjdExlbmd0aCk7XG4gIH1cbiAgcmVmZXJlbmNlRnJhbWVzRW50cnkodmFsdWVzOiBBcnJheVZhbHVlczxSZW5kZXJUcmVlRnJhbWU+LCBpbmRleDogbnVtYmVyKSB7XG4gICAgcmV0dXJuIGFycmF5VmFsdWVzRW50cnkodmFsdWVzLCBpbmRleCwgZnJhbWVSZWFkZXIuc3RydWN0TGVuZ3RoKTtcbiAgfVxuICBkaXNwb3NlZENvbXBvbmVudElkc0VudHJ5KHZhbHVlczogQXJyYXlWYWx1ZXM8bnVtYmVyPiwgaW5kZXg6IG51bWJlcikge1xuICAgIGNvbnN0IHBvaW50ZXIgPSBhcnJheVZhbHVlc0VudHJ5KHZhbHVlcywgaW5kZXgsIC8qIGludCBsZW5ndGggKi8gNCk7XG4gICAgcmV0dXJuIHBsYXRmb3JtLnJlYWRJbnQzMkZpZWxkKHBvaW50ZXIgYXMgYW55IGFzIFBvaW50ZXIpO1xuICB9XG4gIGRpc3Bvc2VkRXZlbnRIYW5kbGVySWRzRW50cnkodmFsdWVzOiBBcnJheVZhbHVlczxudW1iZXI+LCBpbmRleDogbnVtYmVyKSB7XG4gICAgY29uc3QgcG9pbnRlciA9IGFycmF5VmFsdWVzRW50cnkodmFsdWVzLCBpbmRleCwgLyogaW50IGxlbmd0aCAqLyA0KTtcbiAgICByZXR1cm4gcGxhdGZvcm0ucmVhZEludDMyRmllbGQocG9pbnRlciBhcyBhbnkgYXMgUG9pbnRlcik7XG4gIH1cblxuICBhcnJheVJhbmdlUmVhZGVyID0gYXJyYXlSYW5nZVJlYWRlcjtcbiAgYXJyYXlTZWdtZW50UmVhZGVyID0gYXJyYXlTZWdtZW50UmVhZGVyO1xuICBkaWZmUmVhZGVyID0gZGlmZlJlYWRlcjtcbiAgZWRpdFJlYWRlciA9IGVkaXRSZWFkZXI7XG4gIGZyYW1lUmVhZGVyID0gZnJhbWVSZWFkZXI7XG59XG5cbi8vIEtlZXAgaW4gc3luYyB3aXRoIG1lbW9yeSBsYXlvdXQgaW4gQXJyYXlSYW5nZS5jc1xuY29uc3QgYXJyYXlSYW5nZVJlYWRlciA9IHtcbiAgc3RydWN0TGVuZ3RoOiA4LFxuICB2YWx1ZXM6IDxUPihhcnJheVJhbmdlOiBBcnJheVJhbmdlPFQ+KSA9PiBwbGF0Zm9ybS5yZWFkT2JqZWN0RmllbGQ8U3lzdGVtX0FycmF5PFQ+PihhcnJheVJhbmdlIGFzIGFueSwgMCkgYXMgYW55IGFzIEFycmF5VmFsdWVzPFQ+LFxuICBjb3VudDogPFQ+KGFycmF5UmFuZ2U6IEFycmF5UmFuZ2U8VD4pID0+IHBsYXRmb3JtLnJlYWRJbnQzMkZpZWxkKGFycmF5UmFuZ2UgYXMgYW55LCA0KSxcbn07XG5cbi8vIEtlZXAgaW4gc3luYyB3aXRoIG1lbW9yeSBsYXlvdXQgaW4gQXJyYXlTZWdtZW50XG5jb25zdCBhcnJheVNlZ21lbnRSZWFkZXIgPSB7XG4gIHN0cnVjdExlbmd0aDogMTIsXG4gIHZhbHVlczogPFQ+KGFycmF5U2VnbWVudDogQXJyYXlTZWdtZW50PFQ+KSA9PiBwbGF0Zm9ybS5yZWFkT2JqZWN0RmllbGQ8U3lzdGVtX0FycmF5PFQ+PihhcnJheVNlZ21lbnQgYXMgYW55LCAwKSBhcyBhbnkgYXMgQXJyYXlWYWx1ZXM8VD4sXG4gIG9mZnNldDogPFQ+KGFycmF5U2VnbWVudDogQXJyYXlTZWdtZW50PFQ+KSA9PiBwbGF0Zm9ybS5yZWFkSW50MzJGaWVsZChhcnJheVNlZ21lbnQgYXMgYW55LCA0KSxcbiAgY291bnQ6IDxUPihhcnJheVNlZ21lbnQ6IEFycmF5U2VnbWVudDxUPikgPT4gcGxhdGZvcm0ucmVhZEludDMyRmllbGQoYXJyYXlTZWdtZW50IGFzIGFueSwgOCksXG59O1xuXG4vLyBLZWVwIGluIHN5bmMgd2l0aCBtZW1vcnkgbGF5b3V0IGluIFJlbmRlclRyZWVEaWZmLmNzXG5jb25zdCBkaWZmUmVhZGVyID0ge1xuICBzdHJ1Y3RMZW5ndGg6IDQgKyBhcnJheVNlZ21lbnRSZWFkZXIuc3RydWN0TGVuZ3RoLFxuICBjb21wb25lbnRJZDogKGRpZmY6IFJlbmRlclRyZWVEaWZmKSA9PiBwbGF0Zm9ybS5yZWFkSW50MzJGaWVsZChkaWZmIGFzIGFueSwgMCksXG4gIGVkaXRzOiAoZGlmZjogUmVuZGVyVHJlZURpZmYpID0+IHBsYXRmb3JtLnJlYWRTdHJ1Y3RGaWVsZDxQb2ludGVyPihkaWZmIGFzIGFueSwgNCkgYXMgYW55IGFzIEFycmF5U2VnbWVudDxSZW5kZXJUcmVlRWRpdD4sXG4gIGVkaXRzRW50cnk6ICh2YWx1ZXM6IEFycmF5VmFsdWVzPFJlbmRlclRyZWVFZGl0PiwgaW5kZXg6IG51bWJlcikgPT4gYXJyYXlWYWx1ZXNFbnRyeSh2YWx1ZXMsIGluZGV4LCBlZGl0UmVhZGVyLnN0cnVjdExlbmd0aCksXG59O1xuXG4vLyBLZWVwIGluIHN5bmMgd2l0aCBtZW1vcnkgbGF5b3V0IGluIFJlbmRlclRyZWVFZGl0LmNzXG5jb25zdCBlZGl0UmVhZGVyID0ge1xuICBzdHJ1Y3RMZW5ndGg6IDE2LFxuICBlZGl0VHlwZTogKGVkaXQ6IFJlbmRlclRyZWVFZGl0KSA9PiBwbGF0Zm9ybS5yZWFkSW50MzJGaWVsZChlZGl0IGFzIGFueSwgMCkgYXMgRWRpdFR5cGUsXG4gIHNpYmxpbmdJbmRleDogKGVkaXQ6IFJlbmRlclRyZWVFZGl0KSA9PiBwbGF0Zm9ybS5yZWFkSW50MzJGaWVsZChlZGl0IGFzIGFueSwgNCksXG4gIG5ld1RyZWVJbmRleDogKGVkaXQ6IFJlbmRlclRyZWVFZGl0KSA9PiBwbGF0Zm9ybS5yZWFkSW50MzJGaWVsZChlZGl0IGFzIGFueSwgOCksXG4gIHJlbW92ZWRBdHRyaWJ1dGVOYW1lOiAoZWRpdDogUmVuZGVyVHJlZUVkaXQpID0+IHBsYXRmb3JtLnJlYWRTdHJpbmdGaWVsZChlZGl0IGFzIGFueSwgMTIpLFxufTtcblxuLy8gS2VlcCBpbiBzeW5jIHdpdGggbWVtb3J5IGxheW91dCBpbiBSZW5kZXJUcmVlRnJhbWUuY3NcbmNvbnN0IGZyYW1lUmVhZGVyID0ge1xuICBzdHJ1Y3RMZW5ndGg6IDI4LFxuICBmcmFtZVR5cGU6IChmcmFtZTogUmVuZGVyVHJlZUZyYW1lKSA9PiBwbGF0Zm9ybS5yZWFkSW50MzJGaWVsZChmcmFtZSBhcyBhbnksIDQpIGFzIEZyYW1lVHlwZSxcbiAgc3VidHJlZUxlbmd0aDogKGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpID0+IHBsYXRmb3JtLnJlYWRJbnQzMkZpZWxkKGZyYW1lIGFzIGFueSwgOCksXG4gIGVsZW1lbnRSZWZlcmVuY2VDYXB0dXJlSWQ6IChmcmFtZTogUmVuZGVyVHJlZUZyYW1lKSA9PiBwbGF0Zm9ybS5yZWFkU3RyaW5nRmllbGQoZnJhbWUgYXMgYW55LCAxNiksXG4gIGNvbXBvbmVudElkOiAoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSkgPT4gcGxhdGZvcm0ucmVhZEludDMyRmllbGQoZnJhbWUgYXMgYW55LCAxMiksXG4gIGVsZW1lbnROYW1lOiAoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSkgPT4gcGxhdGZvcm0ucmVhZFN0cmluZ0ZpZWxkKGZyYW1lIGFzIGFueSwgMTYpLFxuICB0ZXh0Q29udGVudDogKGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpID0+IHBsYXRmb3JtLnJlYWRTdHJpbmdGaWVsZChmcmFtZSBhcyBhbnksIDE2KSxcbiAgbWFya3VwQ29udGVudDogKGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpID0+IHBsYXRmb3JtLnJlYWRTdHJpbmdGaWVsZChmcmFtZSBhcyBhbnksIDE2KSEsXG4gIGF0dHJpYnV0ZU5hbWU6IChmcmFtZTogUmVuZGVyVHJlZUZyYW1lKSA9PiBwbGF0Zm9ybS5yZWFkU3RyaW5nRmllbGQoZnJhbWUgYXMgYW55LCAxNiksXG4gIGF0dHJpYnV0ZVZhbHVlOiAoZnJhbWU6IFJlbmRlclRyZWVGcmFtZSkgPT4gcGxhdGZvcm0ucmVhZFN0cmluZ0ZpZWxkKGZyYW1lIGFzIGFueSwgMjQpLFxuICBhdHRyaWJ1dGVFdmVudEhhbmRsZXJJZDogKGZyYW1lOiBSZW5kZXJUcmVlRnJhbWUpID0+IHBsYXRmb3JtLnJlYWRJbnQzMkZpZWxkKGZyYW1lIGFzIGFueSwgOCksXG59O1xuXG5mdW5jdGlvbiBhcnJheVZhbHVlc0VudHJ5PFQ+KGFycmF5VmFsdWVzOiBBcnJheVZhbHVlczxUPiwgaW5kZXg6IG51bWJlciwgaXRlbVNpemU6IG51bWJlcik6IFQge1xuICByZXR1cm4gcGxhdGZvcm0uZ2V0QXJyYXlFbnRyeVB0cihhcnJheVZhbHVlcyBhcyBhbnkgYXMgU3lzdGVtX0FycmF5PFQ+LCBpbmRleCwgaXRlbVNpemUpIGFzIGFueSBhcyBUO1xufVxuIiwiaW1wb3J0IHsgU3lzdGVtX09iamVjdCwgU3lzdGVtX1N0cmluZywgU3lzdGVtX0FycmF5LCBNZXRob2RIYW5kbGUsIFBvaW50ZXIgfSBmcm9tICcuLi9QbGF0Zm9ybS9QbGF0Zm9ybSc7XG5pbXBvcnQgeyBwbGF0Zm9ybSB9IGZyb20gJy4uL0Vudmlyb25tZW50JztcbmltcG9ydCB7IFJlbmRlckJhdGNoIH0gZnJvbSAnLi9SZW5kZXJCYXRjaC9SZW5kZXJCYXRjaCc7XG5pbXBvcnQgeyBCcm93c2VyUmVuZGVyZXIgfSBmcm9tICcuL0Jyb3dzZXJSZW5kZXJlcic7XG5cbnR5cGUgQnJvd3NlclJlbmRlcmVyUmVnaXN0cnkgPSB7IFticm93c2VyUmVuZGVyZXJJZDogbnVtYmVyXTogQnJvd3NlclJlbmRlcmVyIH07XG5jb25zdCBicm93c2VyUmVuZGVyZXJzOiBCcm93c2VyUmVuZGVyZXJSZWdpc3RyeSA9IHt9O1xuXG5leHBvcnQgZnVuY3Rpb24gYXR0YWNoUm9vdENvbXBvbmVudFRvRWxlbWVudChicm93c2VyUmVuZGVyZXJJZDogbnVtYmVyLCBlbGVtZW50U2VsZWN0b3I6IHN0cmluZywgY29tcG9uZW50SWQ6IG51bWJlcikge1xuICBjb25zdCBlbGVtZW50ID0gZG9jdW1lbnQucXVlcnlTZWxlY3RvcihlbGVtZW50U2VsZWN0b3IpO1xuICBpZiAoIWVsZW1lbnQpIHtcbiAgICB0aHJvdyBuZXcgRXJyb3IoYENvdWxkIG5vdCBmaW5kIGFueSBlbGVtZW50IG1hdGNoaW5nIHNlbGVjdG9yICcke2VsZW1lbnRTZWxlY3Rvcn0nLmApO1xuICB9XG5cbiAgbGV0IGJyb3dzZXJSZW5kZXJlciA9IGJyb3dzZXJSZW5kZXJlcnNbYnJvd3NlclJlbmRlcmVySWRdO1xuICBpZiAoIWJyb3dzZXJSZW5kZXJlcikge1xuICAgIGJyb3dzZXJSZW5kZXJlciA9IGJyb3dzZXJSZW5kZXJlcnNbYnJvd3NlclJlbmRlcmVySWRdID0gbmV3IEJyb3dzZXJSZW5kZXJlcihicm93c2VyUmVuZGVyZXJJZCk7XG4gIH1cbiAgYnJvd3NlclJlbmRlcmVyLmF0dGFjaFJvb3RDb21wb25lbnRUb0VsZW1lbnQoY29tcG9uZW50SWQsIGVsZW1lbnQpO1xufVxuXG5leHBvcnQgZnVuY3Rpb24gcmVuZGVyQmF0Y2goYnJvd3NlclJlbmRlcmVySWQ6IG51bWJlciwgYmF0Y2g6IFJlbmRlckJhdGNoKSB7XG4gIGNvbnN0IGJyb3dzZXJSZW5kZXJlciA9IGJyb3dzZXJSZW5kZXJlcnNbYnJvd3NlclJlbmRlcmVySWRdO1xuICBpZiAoIWJyb3dzZXJSZW5kZXJlcikge1xuICAgIHRocm93IG5ldyBFcnJvcihgVGhlcmUgaXMgbm8gYnJvd3NlciByZW5kZXJlciB3aXRoIElEICR7YnJvd3NlclJlbmRlcmVySWR9LmApO1xuICB9XG5cbiAgY29uc3QgYXJyYXlSYW5nZVJlYWRlciA9IGJhdGNoLmFycmF5UmFuZ2VSZWFkZXI7XG4gIGNvbnN0IHVwZGF0ZWRDb21wb25lbnRzUmFuZ2UgPSBiYXRjaC51cGRhdGVkQ29tcG9uZW50cygpO1xuICBjb25zdCB1cGRhdGVkQ29tcG9uZW50c1ZhbHVlcyA9IGFycmF5UmFuZ2VSZWFkZXIudmFsdWVzKHVwZGF0ZWRDb21wb25lbnRzUmFuZ2UpO1xuICBjb25zdCB1cGRhdGVkQ29tcG9uZW50c0xlbmd0aCA9IGFycmF5UmFuZ2VSZWFkZXIuY291bnQodXBkYXRlZENvbXBvbmVudHNSYW5nZSk7XG4gIGNvbnN0IHJlZmVyZW5jZUZyYW1lcyA9IGJhdGNoLnJlZmVyZW5jZUZyYW1lcygpO1xuICBjb25zdCByZWZlcmVuY2VGcmFtZXNWYWx1ZXMgPSBhcnJheVJhbmdlUmVhZGVyLnZhbHVlcyhyZWZlcmVuY2VGcmFtZXMpO1xuICBjb25zdCBkaWZmUmVhZGVyID0gYmF0Y2guZGlmZlJlYWRlcjtcblxuICBmb3IgKGxldCBpID0gMDsgaSA8IHVwZGF0ZWRDb21wb25lbnRzTGVuZ3RoOyBpKyspIHtcbiAgICBjb25zdCBkaWZmID0gYmF0Y2gudXBkYXRlZENvbXBvbmVudHNFbnRyeSh1cGRhdGVkQ29tcG9uZW50c1ZhbHVlcywgaSk7XG4gICAgY29uc3QgY29tcG9uZW50SWQgPSBkaWZmUmVhZGVyLmNvbXBvbmVudElkKGRpZmYpO1xuICAgIGNvbnN0IGVkaXRzID0gZGlmZlJlYWRlci5lZGl0cyhkaWZmKTtcbiAgICBicm93c2VyUmVuZGVyZXIudXBkYXRlQ29tcG9uZW50KGJhdGNoLCBjb21wb25lbnRJZCwgZWRpdHMsIHJlZmVyZW5jZUZyYW1lc1ZhbHVlcyk7XG4gIH1cblxuICBjb25zdCBkaXNwb3NlZENvbXBvbmVudElkc1JhbmdlID0gYmF0Y2guZGlzcG9zZWRDb21wb25lbnRJZHMoKTtcbiAgY29uc3QgZGlzcG9zZWRDb21wb25lbnRJZHNWYWx1ZXMgPSBhcnJheVJhbmdlUmVhZGVyLnZhbHVlcyhkaXNwb3NlZENvbXBvbmVudElkc1JhbmdlKTtcbiAgY29uc3QgZGlzcG9zZWRDb21wb25lbnRJZHNMZW5ndGggPSBhcnJheVJhbmdlUmVhZGVyLmNvdW50KGRpc3Bvc2VkQ29tcG9uZW50SWRzUmFuZ2UpO1xuICBmb3IgKGxldCBpID0gMDsgaSA8IGRpc3Bvc2VkQ29tcG9uZW50SWRzTGVuZ3RoOyBpKyspIHtcbiAgICBjb25zdCBjb21wb25lbnRJZCA9IGJhdGNoLmRpc3Bvc2VkQ29tcG9uZW50SWRzRW50cnkoZGlzcG9zZWRDb21wb25lbnRJZHNWYWx1ZXMsIGkpO1xuICAgIGJyb3dzZXJSZW5kZXJlci5kaXNwb3NlQ29tcG9uZW50KGNvbXBvbmVudElkKTtcbiAgfVxuXG4gIGNvbnN0IGRpc3Bvc2VkRXZlbnRIYW5kbGVySWRzUmFuZ2UgPSBiYXRjaC5kaXNwb3NlZEV2ZW50SGFuZGxlcklkcygpO1xuICBjb25zdCBkaXNwb3NlZEV2ZW50SGFuZGxlcklkc1ZhbHVlcyA9IGFycmF5UmFuZ2VSZWFkZXIudmFsdWVzKGRpc3Bvc2VkRXZlbnRIYW5kbGVySWRzUmFuZ2UpO1xuICBjb25zdCBkaXNwb3NlZEV2ZW50SGFuZGxlcklkc0xlbmd0aCA9IGFycmF5UmFuZ2VSZWFkZXIuY291bnQoZGlzcG9zZWRFdmVudEhhbmRsZXJJZHNSYW5nZSk7XG4gIGZvciAobGV0IGkgPSAwOyBpIDwgZGlzcG9zZWRFdmVudEhhbmRsZXJJZHNMZW5ndGg7IGkrKykge1xuICAgIGNvbnN0IGV2ZW50SGFuZGxlcklkID0gYmF0Y2guZGlzcG9zZWRFdmVudEhhbmRsZXJJZHNFbnRyeShkaXNwb3NlZEV2ZW50SGFuZGxlcklkc1ZhbHVlcywgaSk7XG4gICAgYnJvd3NlclJlbmRlcmVyLmRpc3Bvc2VFdmVudEhhbmRsZXIoZXZlbnRIYW5kbGVySWQpO1xuICB9XG59XG4iLCJpbXBvcnQgeyBwbGF0Zm9ybSB9IGZyb20gJy4uL0Vudmlyb25tZW50JztcbmltcG9ydCB7IE1ldGhvZEhhbmRsZSwgU3lzdGVtX1N0cmluZywgU3lzdGVtX0FycmF5IH0gZnJvbSAnLi4vUGxhdGZvcm0vUGxhdGZvcm0nO1xuY29uc3QgaHR0cENsaWVudEFzc2VtYmx5ID0gJ01pY3Jvc29mdC5Bc3BOZXRDb3JlLkJsYXpvcic7XG5jb25zdCBodHRwQ2xpZW50TmFtZXNwYWNlID0gYCR7aHR0cENsaWVudEFzc2VtYmx5fS5IdHRwYDtcbmNvbnN0IGh0dHBDbGllbnRUeXBlTmFtZSA9ICdXZWJBc3NlbWJseUh0dHBNZXNzYWdlSGFuZGxlcic7XG5sZXQgcmVjZWl2ZVJlc3BvbnNlTWV0aG9kOiBNZXRob2RIYW5kbGU7XG5sZXQgYWxsb2NhdGVBcnJheU1ldGhvZDogTWV0aG9kSGFuZGxlO1xuXG4vLyBUaGVzZSBhcmUgdGhlIGZ1bmN0aW9ucyB3ZSdyZSBtYWtpbmcgYXZhaWxhYmxlIGZvciBpbnZvY2F0aW9uIGZyb20gLk5FVFxuZXhwb3J0IGNvbnN0IGludGVybmFsRnVuY3Rpb25zID0ge1xuICBzZW5kQXN5bmNcbn1cblxuYXN5bmMgZnVuY3Rpb24gc2VuZEFzeW5jKGlkOiBudW1iZXIsIGJvZHk6IFN5c3RlbV9BcnJheTxhbnk+LCBqc29uRmV0Y2hBcmdzOiBTeXN0ZW1fU3RyaW5nKSB7XG4gIGxldCByZXNwb25zZTogUmVzcG9uc2U7XG4gIGxldCByZXNwb25zZURhdGE6IEFycmF5QnVmZmVyO1xuXG4gIGNvbnN0IGZldGNoT3B0aW9uczogRmV0Y2hPcHRpb25zID0gSlNPTi5wYXJzZShwbGF0Zm9ybS50b0phdmFTY3JpcHRTdHJpbmcoanNvbkZldGNoQXJncykpO1xuICBjb25zdCByZXF1ZXN0SW5pdDogUmVxdWVzdEluaXQgPSBPYmplY3QuYXNzaWduKGZldGNoT3B0aW9ucy5yZXF1ZXN0SW5pdCwgZmV0Y2hPcHRpb25zLnJlcXVlc3RJbml0T3ZlcnJpZGVzKTtcblxuICBpZiAoYm9keSkge1xuICAgIHJlcXVlc3RJbml0LmJvZHkgPSBwbGF0Zm9ybS50b1VpbnQ4QXJyYXkoYm9keSk7XG4gIH1cblxuICB0cnkge1xuICAgIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2goZmV0Y2hPcHRpb25zLnJlcXVlc3RVcmksIHJlcXVlc3RJbml0KTtcbiAgICByZXNwb25zZURhdGEgPSBhd2FpdCByZXNwb25zZS5hcnJheUJ1ZmZlcigpO1xuICB9IGNhdGNoIChleCkge1xuICAgIGRpc3BhdGNoRXJyb3JSZXNwb25zZShpZCwgZXgudG9TdHJpbmcoKSk7XG4gICAgcmV0dXJuO1xuICB9XG5cbiAgZGlzcGF0Y2hTdWNjZXNzUmVzcG9uc2UoaWQsIHJlc3BvbnNlLCByZXNwb25zZURhdGEpO1xufVxuXG5mdW5jdGlvbiBkaXNwYXRjaFN1Y2Nlc3NSZXNwb25zZShpZDogbnVtYmVyLCByZXNwb25zZTogUmVzcG9uc2UsIHJlc3BvbnNlRGF0YTogQXJyYXlCdWZmZXIpIHtcbiAgY29uc3QgcmVzcG9uc2VEZXNjcmlwdG9yOiBSZXNwb25zZURlc2NyaXB0b3IgPSB7XG4gICAgc3RhdHVzQ29kZTogcmVzcG9uc2Uuc3RhdHVzLFxuICAgIHN0YXR1c1RleHQ6IHJlc3BvbnNlLnN0YXR1c1RleHQsXG4gICAgaGVhZGVyczogW11cbiAgfTtcbiAgcmVzcG9uc2UuaGVhZGVycy5mb3JFYWNoKCh2YWx1ZSwgbmFtZSkgPT4ge1xuICAgIHJlc3BvbnNlRGVzY3JpcHRvci5oZWFkZXJzLnB1c2goW25hbWUsIHZhbHVlXSk7XG4gIH0pO1xuXG4gIGlmICghYWxsb2NhdGVBcnJheU1ldGhvZCkge1xuICAgIGFsbG9jYXRlQXJyYXlNZXRob2QgPSBwbGF0Zm9ybS5maW5kTWV0aG9kKFxuICAgICAgaHR0cENsaWVudEFzc2VtYmx5LFxuICAgICAgaHR0cENsaWVudE5hbWVzcGFjZSxcbiAgICAgIGh0dHBDbGllbnRUeXBlTmFtZSxcbiAgICAgICdBbGxvY2F0ZUFycmF5J1xuICAgICk7XG4gIH1cblxuICAvLyBhbGxvY2F0ZSBhIG1hbmFnZWQgYnl0ZVtdIG9mIHRoZSByaWdodCBzaXplXG4gIGNvbnN0IGRvdE5ldEFycmF5ID0gcGxhdGZvcm0uY2FsbE1ldGhvZChhbGxvY2F0ZUFycmF5TWV0aG9kLCBudWxsLCBbcGxhdGZvcm0udG9Eb3ROZXRTdHJpbmcocmVzcG9uc2VEYXRhLmJ5dGVMZW5ndGgudG9TdHJpbmcoKSldKSBhcyBTeXN0ZW1fQXJyYXk8YW55PjtcblxuICAvLyBnZXQgYW4gVWludDhBcnJheSB2aWV3IG9mIGl0XG4gIGNvbnN0IGFycmF5ID0gcGxhdGZvcm0udG9VaW50OEFycmF5KGRvdE5ldEFycmF5KTtcblxuICAvLyBjb3B5IHRoZSByZXNwb25zZURhdGEgdG8gb3VyIG1hbmFnZWQgYnl0ZVtdXG4gIGFycmF5LnNldChuZXcgVWludDhBcnJheShyZXNwb25zZURhdGEpKTtcblxuICBkaXNwYXRjaFJlc3BvbnNlKFxuICAgIGlkLFxuICAgIHBsYXRmb3JtLnRvRG90TmV0U3RyaW5nKEpTT04uc3RyaW5naWZ5KHJlc3BvbnNlRGVzY3JpcHRvcikpLFxuICAgIGRvdE5ldEFycmF5LFxuICAgIC8qIGVycm9yTWVzc2FnZSAqLyBudWxsXG4gICk7XG59XG5cbmZ1bmN0aW9uIGRpc3BhdGNoRXJyb3JSZXNwb25zZShpZDogbnVtYmVyLCBlcnJvck1lc3NhZ2U6IHN0cmluZykge1xuICBkaXNwYXRjaFJlc3BvbnNlKFxuICAgIGlkLFxuICAgIC8qIHJlc3BvbnNlRGVzY3JpcHRvciAqLyBudWxsLFxuICAgIC8qIHJlc3BvbnNlVGV4dCAqLyBudWxsLFxuICAgIHBsYXRmb3JtLnRvRG90TmV0U3RyaW5nKGVycm9yTWVzc2FnZSlcbiAgKTtcbn1cblxuZnVuY3Rpb24gZGlzcGF0Y2hSZXNwb25zZShpZDogbnVtYmVyLCByZXNwb25zZURlc2NyaXB0b3I6IFN5c3RlbV9TdHJpbmcgfCBudWxsLCByZXNwb25zZURhdGE6IFN5c3RlbV9BcnJheTxhbnk+IHwgbnVsbCwgZXJyb3JNZXNzYWdlOiBTeXN0ZW1fU3RyaW5nIHwgbnVsbCkge1xuICBpZiAoIXJlY2VpdmVSZXNwb25zZU1ldGhvZCkge1xuICAgIHJlY2VpdmVSZXNwb25zZU1ldGhvZCA9IHBsYXRmb3JtLmZpbmRNZXRob2QoXG4gICAgICBodHRwQ2xpZW50QXNzZW1ibHksXG4gICAgICBodHRwQ2xpZW50TmFtZXNwYWNlLFxuICAgICAgaHR0cENsaWVudFR5cGVOYW1lLFxuICAgICAgJ1JlY2VpdmVSZXNwb25zZSdcbiAgICApO1xuICB9XG5cbiAgcGxhdGZvcm0uY2FsbE1ldGhvZChyZWNlaXZlUmVzcG9uc2VNZXRob2QsIG51bGwsIFtcbiAgICBwbGF0Zm9ybS50b0RvdE5ldFN0cmluZyhpZC50b1N0cmluZygpKSxcbiAgICByZXNwb25zZURlc2NyaXB0b3IsXG4gICAgcmVzcG9uc2VEYXRhLFxuICAgIGVycm9yTWVzc2FnZSxcbiAgXSk7XG59XG5cbi8vIEtlZXAgdGhlc2UgaW4gc3luYyB3aXRoIHRoZSAuTkVUIGVxdWl2YWxlbnQgaW4gV2ViQXNzZW1ibHlIdHRwTWVzc2FnZUhhbmRsZXIuY3NcbmludGVyZmFjZSBGZXRjaE9wdGlvbnMge1xuICByZXF1ZXN0VXJpOiBzdHJpbmc7XG4gIHJlcXVlc3RJbml0OiBSZXF1ZXN0SW5pdDtcbiAgcmVxdWVzdEluaXRPdmVycmlkZXM6IFJlcXVlc3RJbml0O1xufVxuXG5pbnRlcmZhY2UgUmVzcG9uc2VEZXNjcmlwdG9yIHtcbiAgLy8gV2UgZG9uJ3QgaGF2ZSBCb2R5VGV4dCBpbiBoZXJlIGJlY2F1c2UgaWYgd2UgZGlkLCB0aGVuIGluIHRoZSBKU09OLXJlc3BvbnNlIGNhc2UgKHdoaWNoXG4gIC8vIGlzIHRoZSBtb3N0IGNvbW1vbiBjYXNlKSwgd2UnZCBiZSBkb3VibGUtZW5jb2RpbmcgaXQsIHNpbmNlIHRoZSBlbnRpcmUgUmVzcG9uc2VEZXNjcmlwdG9yXG4gIC8vIGFsc28gZ2V0cyBKU09OIGVuY29kZWQuIEl0IHdvdWxkIHdvcmsgYnV0IGlzIHR3aWNlIHRoZSBhbW91bnQgb2Ygc3RyaW5nIHByb2Nlc3NpbmcuXG4gIHN0YXR1c0NvZGU6IG51bWJlcjtcbiAgc3RhdHVzVGV4dDogc3RyaW5nO1xuICBoZWFkZXJzOiBzdHJpbmdbXVtdO1xufVxuIiwiaW1wb3J0ICdAZG90bmV0L2pzaW50ZXJvcCc7XG5cbmxldCBoYXNSZWdpc3RlcmVkRXZlbnRMaXN0ZW5lcnMgPSBmYWxzZTtcblxuLy8gV2lsbCBiZSBpbml0aWFsaXplZCBvbmNlIHNvbWVvbmUgcmVnaXN0ZXJzXG5sZXQgbm90aWZ5TG9jYXRpb25DaGFuZ2VkQ2FsbGJhY2s6IHsgYXNzZW1ibHlOYW1lOiBzdHJpbmcsIGZ1bmN0aW9uTmFtZTogc3RyaW5nIH0gfCBudWxsID0gbnVsbDtcblxuLy8gVGhlc2UgYXJlIHRoZSBmdW5jdGlvbnMgd2UncmUgbWFraW5nIGF2YWlsYWJsZSBmb3IgaW52b2NhdGlvbiBmcm9tIC5ORVRcbmV4cG9ydCBjb25zdCBpbnRlcm5hbEZ1bmN0aW9ucyA9IHtcbiAgZW5hYmxlTmF2aWdhdGlvbkludGVyY2VwdGlvbixcbiAgbmF2aWdhdGVUbyxcbiAgZ2V0QmFzZVVSSTogKCkgPT4gZG9jdW1lbnQuYmFzZVVSSSxcbiAgZ2V0TG9jYXRpb25IcmVmOiAoKSA9PiBsb2NhdGlvbi5ocmVmLFxufVxuXG5mdW5jdGlvbiBlbmFibGVOYXZpZ2F0aW9uSW50ZXJjZXB0aW9uKGFzc2VtYmx5TmFtZTogc3RyaW5nLCBmdW5jdGlvbk5hbWU6IHN0cmluZykge1xuICBpZiAoaGFzUmVnaXN0ZXJlZEV2ZW50TGlzdGVuZXJzIHx8IGFzc2VtYmx5TmFtZSA9PT0gdW5kZWZpbmVkIHx8IGZ1bmN0aW9uTmFtZSA9PT0gdW5kZWZpbmVkKSB7XG4gICAgcmV0dXJuO1xuICB9XG5cbiAgbm90aWZ5TG9jYXRpb25DaGFuZ2VkQ2FsbGJhY2sgPSB7IGFzc2VtYmx5TmFtZSwgZnVuY3Rpb25OYW1lIH07XG4gIGhhc1JlZ2lzdGVyZWRFdmVudExpc3RlbmVycyA9IHRydWU7XG5cbiAgZG9jdW1lbnQuYWRkRXZlbnRMaXN0ZW5lcignY2xpY2snLCBldmVudCA9PiB7XG4gICAgLy8gSW50ZXJjZXB0IGNsaWNrcyBvbiBhbGwgPGE+IGVsZW1lbnRzIHdoZXJlIHRoZSBocmVmIGlzIHdpdGhpbiB0aGUgPGJhc2UgaHJlZj4gVVJJIHNwYWNlXG4gICAgLy8gV2UgbXVzdCBleHBsaWNpdGx5IGNoZWNrIGlmIGl0IGhhcyBhbiAnaHJlZicgYXR0cmlidXRlLCBiZWNhdXNlIGlmIGl0IGRvZXNuJ3QsIHRoZSByZXN1bHQgbWlnaHQgYmUgbnVsbCBvciBhbiBlbXB0eSBzdHJpbmcgZGVwZW5kaW5nIG9uIHRoZSBicm93c2VyXG4gICAgY29uc3QgYW5jaG9yVGFyZ2V0ID0gZmluZENsb3Nlc3RBbmNlc3RvcihldmVudC50YXJnZXQgYXMgRWxlbWVudCB8IG51bGwsICdBJykgYXMgSFRNTEFuY2hvckVsZW1lbnQ7XG4gICAgY29uc3QgaHJlZkF0dHJpYnV0ZU5hbWUgPSAnaHJlZic7XG4gICAgaWYgKGFuY2hvclRhcmdldCAmJiBhbmNob3JUYXJnZXQuaGFzQXR0cmlidXRlKGhyZWZBdHRyaWJ1dGVOYW1lKSAmJiBldmVudC5idXR0b24gPT09IDApIHtcbiAgICAgIGNvbnN0IGhyZWYgPSBhbmNob3JUYXJnZXQuZ2V0QXR0cmlidXRlKGhyZWZBdHRyaWJ1dGVOYW1lKSE7XG4gICAgICBjb25zdCBhYnNvbHV0ZUhyZWYgPSB0b0Fic29sdXRlVXJpKGhyZWYpO1xuICAgICAgY29uc3QgdGFyZ2V0QXR0cmlidXRlVmFsdWUgPSBhbmNob3JUYXJnZXQuZ2V0QXR0cmlidXRlKCd0YXJnZXQnKTtcbiAgICAgIGNvbnN0IG9wZW5zSW5TYW1lRnJhbWUgPSAhdGFyZ2V0QXR0cmlidXRlVmFsdWUgfHwgdGFyZ2V0QXR0cmlidXRlVmFsdWUgPT09ICdfc2VsZic7XG5cbiAgICAgIC8vIERvbid0IHN0b3AgY3RybC9tZXRhLWNsaWNrIChldGMpIGZyb20gb3BlbmluZyBsaW5rcyBpbiBuZXcgdGFicy93aW5kb3dzXG4gICAgICBpZiAoaXNXaXRoaW5CYXNlVXJpU3BhY2UoYWJzb2x1dGVIcmVmKSAmJiAhZXZlbnRIYXNTcGVjaWFsS2V5KGV2ZW50KSAmJiBvcGVuc0luU2FtZUZyYW1lKSB7XG4gICAgICAgIGV2ZW50LnByZXZlbnREZWZhdWx0KCk7XG4gICAgICAgIHBlcmZvcm1JbnRlcm5hbE5hdmlnYXRpb24oYWJzb2x1dGVIcmVmKTtcbiAgICAgIH1cbiAgICB9XG4gIH0pO1xuXG4gIHdpbmRvdy5hZGRFdmVudExpc3RlbmVyKCdwb3BzdGF0ZScsIGhhbmRsZUludGVybmFsTmF2aWdhdGlvbik7XG59XG5cbmV4cG9ydCBmdW5jdGlvbiBuYXZpZ2F0ZVRvKHVyaTogc3RyaW5nLCBmb3JjZUxvYWQ6IGJvb2xlYW4pIHtcbiAgY29uc3QgYWJzb2x1dGVVcmkgPSB0b0Fic29sdXRlVXJpKHVyaSk7XG5cbiAgaWYgKCFmb3JjZUxvYWQgJiYgaXNXaXRoaW5CYXNlVXJpU3BhY2UoYWJzb2x1dGVVcmkpKSB7XG4gICAgcGVyZm9ybUludGVybmFsTmF2aWdhdGlvbihhYnNvbHV0ZVVyaSk7XG4gIH0gZWxzZSB7XG4gICAgbG9jYXRpb24uaHJlZiA9IHVyaTtcbiAgfVxufVxuXG5mdW5jdGlvbiBwZXJmb3JtSW50ZXJuYWxOYXZpZ2F0aW9uKGFic29sdXRlSW50ZXJuYWxIcmVmOiBzdHJpbmcpIHtcbiAgaGlzdG9yeS5wdXNoU3RhdGUobnVsbCwgLyogaWdub3JlZCB0aXRsZSAqLyAnJywgYWJzb2x1dGVJbnRlcm5hbEhyZWYpO1xuICBoYW5kbGVJbnRlcm5hbE5hdmlnYXRpb24oKTtcbn1cblxuYXN5bmMgZnVuY3Rpb24gaGFuZGxlSW50ZXJuYWxOYXZpZ2F0aW9uKCkge1xuICBpZiAobm90aWZ5TG9jYXRpb25DaGFuZ2VkQ2FsbGJhY2spIHtcbiAgICBhd2FpdCBEb3ROZXQuaW52b2tlTWV0aG9kQXN5bmMoXG4gICAgICBub3RpZnlMb2NhdGlvbkNoYW5nZWRDYWxsYmFjay5hc3NlbWJseU5hbWUsXG4gICAgICBub3RpZnlMb2NhdGlvbkNoYW5nZWRDYWxsYmFjay5mdW5jdGlvbk5hbWUsXG4gICAgICBsb2NhdGlvbi5ocmVmXG4gICAgKTtcbiAgfVxufVxuXG5sZXQgdGVzdEFuY2hvcjogSFRNTEFuY2hvckVsZW1lbnQ7XG5mdW5jdGlvbiB0b0Fic29sdXRlVXJpKHJlbGF0aXZlVXJpOiBzdHJpbmcpIHtcbiAgdGVzdEFuY2hvciA9IHRlc3RBbmNob3IgfHwgZG9jdW1lbnQuY3JlYXRlRWxlbWVudCgnYScpO1xuICB0ZXN0QW5jaG9yLmhyZWYgPSByZWxhdGl2ZVVyaTtcbiAgcmV0dXJuIHRlc3RBbmNob3IuaHJlZjtcbn1cblxuZnVuY3Rpb24gZmluZENsb3Nlc3RBbmNlc3RvcihlbGVtZW50OiBFbGVtZW50IHwgbnVsbCwgdGFnTmFtZTogc3RyaW5nKSB7XG4gIHJldHVybiAhZWxlbWVudFxuICAgID8gbnVsbFxuICAgIDogZWxlbWVudC50YWdOYW1lID09PSB0YWdOYW1lXG4gICAgICA/IGVsZW1lbnRcbiAgICAgIDogZmluZENsb3Nlc3RBbmNlc3RvcihlbGVtZW50LnBhcmVudEVsZW1lbnQsIHRhZ05hbWUpXG59XG5cbmZ1bmN0aW9uIGlzV2l0aGluQmFzZVVyaVNwYWNlKGhyZWY6IHN0cmluZykge1xuICBjb25zdCBiYXNlVXJpV2l0aFRyYWlsaW5nU2xhc2ggPSB0b0Jhc2VVcmlXaXRoVHJhaWxpbmdTbGFzaChkb2N1bWVudC5iYXNlVVJJISk7IC8vIFRPRE86IE1pZ2h0IGJhc2VVUkkgcmVhbGx5IGJlIG51bGw/XG4gIHJldHVybiBocmVmLnN0YXJ0c1dpdGgoYmFzZVVyaVdpdGhUcmFpbGluZ1NsYXNoKTtcbn1cblxuZnVuY3Rpb24gdG9CYXNlVXJpV2l0aFRyYWlsaW5nU2xhc2goYmFzZVVyaTogc3RyaW5nKSB7XG4gIHJldHVybiBiYXNlVXJpLnN1YnN0cigwLCBiYXNlVXJpLmxhc3RJbmRleE9mKCcvJykgKyAxKTtcbn1cblxuZnVuY3Rpb24gZXZlbnRIYXNTcGVjaWFsS2V5KGV2ZW50OiBNb3VzZUV2ZW50KSB7XG4gIHJldHVybiBldmVudC5jdHJsS2V5IHx8IGV2ZW50LnNoaWZ0S2V5IHx8IGV2ZW50LmFsdEtleSB8fCBldmVudC5tZXRhS2V5O1xufVxuIiwiXCJ1c2Ugc3RyaWN0XCI7XHJcbi8vIFRoaXMgaXMgYSBzaW5nbGUtZmlsZSBzZWxmLWNvbnRhaW5lZCBtb2R1bGUgdG8gYXZvaWQgdGhlIG5lZWQgZm9yIGEgV2VicGFjayBidWlsZFxyXG52YXIgRG90TmV0O1xyXG4oZnVuY3Rpb24gKERvdE5ldCkge1xyXG4gICAgd2luZG93LkRvdE5ldCA9IERvdE5ldDsgLy8gRW5zdXJlIHJlYWNoYWJsZSBmcm9tIGFueXdoZXJlXHJcbiAgICB2YXIganNvblJldml2ZXJzID0gW107XHJcbiAgICB2YXIgcGVuZGluZ0FzeW5jQ2FsbHMgPSB7fTtcclxuICAgIHZhciBjYWNoZWRKU0Z1bmN0aW9ucyA9IHt9O1xyXG4gICAgdmFyIG5leHRBc3luY0NhbGxJZCA9IDE7IC8vIFN0YXJ0IGF0IDEgYmVjYXVzZSB6ZXJvIHNpZ25hbHMgXCJubyByZXNwb25zZSBuZWVkZWRcIlxyXG4gICAgdmFyIGRvdE5ldERpc3BhdGNoZXIgPSBudWxsO1xyXG4gICAgLyoqXHJcbiAgICAgKiBTZXRzIHRoZSBzcGVjaWZpZWQgLk5FVCBjYWxsIGRpc3BhdGNoZXIgYXMgdGhlIGN1cnJlbnQgaW5zdGFuY2Ugc28gdGhhdCBpdCB3aWxsIGJlIHVzZWRcclxuICAgICAqIGZvciBmdXR1cmUgaW52b2NhdGlvbnMuXHJcbiAgICAgKlxyXG4gICAgICogQHBhcmFtIGRpc3BhdGNoZXIgQW4gb2JqZWN0IHRoYXQgY2FuIGRpc3BhdGNoIGNhbGxzIGZyb20gSmF2YVNjcmlwdCB0byBhIC5ORVQgcnVudGltZS5cclxuICAgICAqL1xyXG4gICAgZnVuY3Rpb24gYXR0YWNoRGlzcGF0Y2hlcihkaXNwYXRjaGVyKSB7XHJcbiAgICAgICAgZG90TmV0RGlzcGF0Y2hlciA9IGRpc3BhdGNoZXI7XHJcbiAgICB9XHJcbiAgICBEb3ROZXQuYXR0YWNoRGlzcGF0Y2hlciA9IGF0dGFjaERpc3BhdGNoZXI7XHJcbiAgICAvKipcclxuICAgICAqIEFkZHMgYSBKU09OIHJldml2ZXIgY2FsbGJhY2sgdGhhdCB3aWxsIGJlIHVzZWQgd2hlbiBwYXJzaW5nIGFyZ3VtZW50cyByZWNlaXZlZCBmcm9tIC5ORVQuXHJcbiAgICAgKiBAcGFyYW0gcmV2aXZlciBUaGUgcmV2aXZlciB0byBhZGQuXHJcbiAgICAgKi9cclxuICAgIGZ1bmN0aW9uIGF0dGFjaFJldml2ZXIocmV2aXZlcikge1xyXG4gICAgICAgIGpzb25SZXZpdmVycy5wdXNoKHJldml2ZXIpO1xyXG4gICAgfVxyXG4gICAgRG90TmV0LmF0dGFjaFJldml2ZXIgPSBhdHRhY2hSZXZpdmVyO1xyXG4gICAgLyoqXHJcbiAgICAgKiBJbnZva2VzIHRoZSBzcGVjaWZpZWQgLk5FVCBwdWJsaWMgbWV0aG9kIHN5bmNocm9ub3VzbHkuIE5vdCBhbGwgaG9zdGluZyBzY2VuYXJpb3Mgc3VwcG9ydFxyXG4gICAgICogc3luY2hyb25vdXMgaW52b2NhdGlvbiwgc28gaWYgcG9zc2libGUgdXNlIGludm9rZU1ldGhvZEFzeW5jIGluc3RlYWQuXHJcbiAgICAgKlxyXG4gICAgICogQHBhcmFtIGFzc2VtYmx5TmFtZSBUaGUgc2hvcnQgbmFtZSAod2l0aG91dCBrZXkvdmVyc2lvbiBvciAuZGxsIGV4dGVuc2lvbikgb2YgdGhlIC5ORVQgYXNzZW1ibHkgY29udGFpbmluZyB0aGUgbWV0aG9kLlxyXG4gICAgICogQHBhcmFtIG1ldGhvZElkZW50aWZpZXIgVGhlIGlkZW50aWZpZXIgb2YgdGhlIG1ldGhvZCB0byBpbnZva2UuIFRoZSBtZXRob2QgbXVzdCBoYXZlIGEgW0pTSW52b2thYmxlXSBhdHRyaWJ1dGUgc3BlY2lmeWluZyB0aGlzIGlkZW50aWZpZXIuXHJcbiAgICAgKiBAcGFyYW0gYXJncyBBcmd1bWVudHMgdG8gcGFzcyB0byB0aGUgbWV0aG9kLCBlYWNoIG9mIHdoaWNoIG11c3QgYmUgSlNPTi1zZXJpYWxpemFibGUuXHJcbiAgICAgKiBAcmV0dXJucyBUaGUgcmVzdWx0IG9mIHRoZSBvcGVyYXRpb24uXHJcbiAgICAgKi9cclxuICAgIGZ1bmN0aW9uIGludm9rZU1ldGhvZChhc3NlbWJseU5hbWUsIG1ldGhvZElkZW50aWZpZXIpIHtcclxuICAgICAgICB2YXIgYXJncyA9IFtdO1xyXG4gICAgICAgIGZvciAodmFyIF9pID0gMjsgX2kgPCBhcmd1bWVudHMubGVuZ3RoOyBfaSsrKSB7XHJcbiAgICAgICAgICAgIGFyZ3NbX2kgLSAyXSA9IGFyZ3VtZW50c1tfaV07XHJcbiAgICAgICAgfVxyXG4gICAgICAgIHJldHVybiBpbnZva2VQb3NzaWJsZUluc3RhbmNlTWV0aG9kKGFzc2VtYmx5TmFtZSwgbWV0aG9kSWRlbnRpZmllciwgbnVsbCwgYXJncyk7XHJcbiAgICB9XHJcbiAgICBEb3ROZXQuaW52b2tlTWV0aG9kID0gaW52b2tlTWV0aG9kO1xyXG4gICAgLyoqXHJcbiAgICAgKiBJbnZva2VzIHRoZSBzcGVjaWZpZWQgLk5FVCBwdWJsaWMgbWV0aG9kIGFzeW5jaHJvbm91c2x5LlxyXG4gICAgICpcclxuICAgICAqIEBwYXJhbSBhc3NlbWJseU5hbWUgVGhlIHNob3J0IG5hbWUgKHdpdGhvdXQga2V5L3ZlcnNpb24gb3IgLmRsbCBleHRlbnNpb24pIG9mIHRoZSAuTkVUIGFzc2VtYmx5IGNvbnRhaW5pbmcgdGhlIG1ldGhvZC5cclxuICAgICAqIEBwYXJhbSBtZXRob2RJZGVudGlmaWVyIFRoZSBpZGVudGlmaWVyIG9mIHRoZSBtZXRob2QgdG8gaW52b2tlLiBUaGUgbWV0aG9kIG11c3QgaGF2ZSBhIFtKU0ludm9rYWJsZV0gYXR0cmlidXRlIHNwZWNpZnlpbmcgdGhpcyBpZGVudGlmaWVyLlxyXG4gICAgICogQHBhcmFtIGFyZ3MgQXJndW1lbnRzIHRvIHBhc3MgdG8gdGhlIG1ldGhvZCwgZWFjaCBvZiB3aGljaCBtdXN0IGJlIEpTT04tc2VyaWFsaXphYmxlLlxyXG4gICAgICogQHJldHVybnMgQSBwcm9taXNlIHJlcHJlc2VudGluZyB0aGUgcmVzdWx0IG9mIHRoZSBvcGVyYXRpb24uXHJcbiAgICAgKi9cclxuICAgIGZ1bmN0aW9uIGludm9rZU1ldGhvZEFzeW5jKGFzc2VtYmx5TmFtZSwgbWV0aG9kSWRlbnRpZmllcikge1xyXG4gICAgICAgIHZhciBhcmdzID0gW107XHJcbiAgICAgICAgZm9yICh2YXIgX2kgPSAyOyBfaSA8IGFyZ3VtZW50cy5sZW5ndGg7IF9pKyspIHtcclxuICAgICAgICAgICAgYXJnc1tfaSAtIDJdID0gYXJndW1lbnRzW19pXTtcclxuICAgICAgICB9XHJcbiAgICAgICAgcmV0dXJuIGludm9rZVBvc3NpYmxlSW5zdGFuY2VNZXRob2RBc3luYyhhc3NlbWJseU5hbWUsIG1ldGhvZElkZW50aWZpZXIsIG51bGwsIGFyZ3MpO1xyXG4gICAgfVxyXG4gICAgRG90TmV0Lmludm9rZU1ldGhvZEFzeW5jID0gaW52b2tlTWV0aG9kQXN5bmM7XHJcbiAgICBmdW5jdGlvbiBpbnZva2VQb3NzaWJsZUluc3RhbmNlTWV0aG9kKGFzc2VtYmx5TmFtZSwgbWV0aG9kSWRlbnRpZmllciwgZG90TmV0T2JqZWN0SWQsIGFyZ3MpIHtcclxuICAgICAgICB2YXIgZGlzcGF0Y2hlciA9IGdldFJlcXVpcmVkRGlzcGF0Y2hlcigpO1xyXG4gICAgICAgIGlmIChkaXNwYXRjaGVyLmludm9rZURvdE5ldEZyb21KUykge1xyXG4gICAgICAgICAgICB2YXIgYXJnc0pzb24gPSBKU09OLnN0cmluZ2lmeShhcmdzLCBhcmdSZXBsYWNlcik7XHJcbiAgICAgICAgICAgIHZhciByZXN1bHRKc29uID0gZGlzcGF0Y2hlci5pbnZva2VEb3ROZXRGcm9tSlMoYXNzZW1ibHlOYW1lLCBtZXRob2RJZGVudGlmaWVyLCBkb3ROZXRPYmplY3RJZCwgYXJnc0pzb24pO1xyXG4gICAgICAgICAgICByZXR1cm4gcmVzdWx0SnNvbiA/IHBhcnNlSnNvbldpdGhSZXZpdmVycyhyZXN1bHRKc29uKSA6IG51bGw7XHJcbiAgICAgICAgfVxyXG4gICAgICAgIGVsc2Uge1xyXG4gICAgICAgICAgICB0aHJvdyBuZXcgRXJyb3IoJ1RoZSBjdXJyZW50IGRpc3BhdGNoZXIgZG9lcyBub3Qgc3VwcG9ydCBzeW5jaHJvbm91cyBjYWxscyBmcm9tIEpTIHRvIC5ORVQuIFVzZSBpbnZva2VNZXRob2RBc3luYyBpbnN0ZWFkLicpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuICAgIGZ1bmN0aW9uIGludm9rZVBvc3NpYmxlSW5zdGFuY2VNZXRob2RBc3luYyhhc3NlbWJseU5hbWUsIG1ldGhvZElkZW50aWZpZXIsIGRvdE5ldE9iamVjdElkLCBhcmdzKSB7XHJcbiAgICAgICAgdmFyIGFzeW5jQ2FsbElkID0gbmV4dEFzeW5jQ2FsbElkKys7XHJcbiAgICAgICAgdmFyIHJlc3VsdFByb21pc2UgPSBuZXcgUHJvbWlzZShmdW5jdGlvbiAocmVzb2x2ZSwgcmVqZWN0KSB7XHJcbiAgICAgICAgICAgIHBlbmRpbmdBc3luY0NhbGxzW2FzeW5jQ2FsbElkXSA9IHsgcmVzb2x2ZTogcmVzb2x2ZSwgcmVqZWN0OiByZWplY3QgfTtcclxuICAgICAgICB9KTtcclxuICAgICAgICB0cnkge1xyXG4gICAgICAgICAgICB2YXIgYXJnc0pzb24gPSBKU09OLnN0cmluZ2lmeShhcmdzLCBhcmdSZXBsYWNlcik7XHJcbiAgICAgICAgICAgIGdldFJlcXVpcmVkRGlzcGF0Y2hlcigpLmJlZ2luSW52b2tlRG90TmV0RnJvbUpTKGFzeW5jQ2FsbElkLCBhc3NlbWJseU5hbWUsIG1ldGhvZElkZW50aWZpZXIsIGRvdE5ldE9iamVjdElkLCBhcmdzSnNvbik7XHJcbiAgICAgICAgfVxyXG4gICAgICAgIGNhdGNoIChleCkge1xyXG4gICAgICAgICAgICAvLyBTeW5jaHJvbm91cyBmYWlsdXJlXHJcbiAgICAgICAgICAgIGNvbXBsZXRlUGVuZGluZ0NhbGwoYXN5bmNDYWxsSWQsIGZhbHNlLCBleCk7XHJcbiAgICAgICAgfVxyXG4gICAgICAgIHJldHVybiByZXN1bHRQcm9taXNlO1xyXG4gICAgfVxyXG4gICAgZnVuY3Rpb24gZ2V0UmVxdWlyZWREaXNwYXRjaGVyKCkge1xyXG4gICAgICAgIGlmIChkb3ROZXREaXNwYXRjaGVyICE9PSBudWxsKSB7XHJcbiAgICAgICAgICAgIHJldHVybiBkb3ROZXREaXNwYXRjaGVyO1xyXG4gICAgICAgIH1cclxuICAgICAgICB0aHJvdyBuZXcgRXJyb3IoJ05vIC5ORVQgY2FsbCBkaXNwYXRjaGVyIGhhcyBiZWVuIHNldC4nKTtcclxuICAgIH1cclxuICAgIGZ1bmN0aW9uIGNvbXBsZXRlUGVuZGluZ0NhbGwoYXN5bmNDYWxsSWQsIHN1Y2Nlc3MsIHJlc3VsdE9yRXJyb3IpIHtcclxuICAgICAgICBpZiAoIXBlbmRpbmdBc3luY0NhbGxzLmhhc093blByb3BlcnR5KGFzeW5jQ2FsbElkKSkge1xyXG4gICAgICAgICAgICB0aHJvdyBuZXcgRXJyb3IoXCJUaGVyZSBpcyBubyBwZW5kaW5nIGFzeW5jIGNhbGwgd2l0aCBJRCBcIiArIGFzeW5jQ2FsbElkICsgXCIuXCIpO1xyXG4gICAgICAgIH1cclxuICAgICAgICB2YXIgYXN5bmNDYWxsID0gcGVuZGluZ0FzeW5jQ2FsbHNbYXN5bmNDYWxsSWRdO1xyXG4gICAgICAgIGRlbGV0ZSBwZW5kaW5nQXN5bmNDYWxsc1thc3luY0NhbGxJZF07XHJcbiAgICAgICAgaWYgKHN1Y2Nlc3MpIHtcclxuICAgICAgICAgICAgYXN5bmNDYWxsLnJlc29sdmUocmVzdWx0T3JFcnJvcik7XHJcbiAgICAgICAgfVxyXG4gICAgICAgIGVsc2Uge1xyXG4gICAgICAgICAgICBhc3luY0NhbGwucmVqZWN0KHJlc3VsdE9yRXJyb3IpO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuICAgIC8qKlxyXG4gICAgICogUmVjZWl2ZXMgaW5jb21pbmcgY2FsbHMgZnJvbSAuTkVUIGFuZCBkaXNwYXRjaGVzIHRoZW0gdG8gSmF2YVNjcmlwdC5cclxuICAgICAqL1xyXG4gICAgRG90TmV0LmpzQ2FsbERpc3BhdGNoZXIgPSB7XHJcbiAgICAgICAgLyoqXHJcbiAgICAgICAgICogRmluZHMgdGhlIEphdmFTY3JpcHQgZnVuY3Rpb24gbWF0Y2hpbmcgdGhlIHNwZWNpZmllZCBpZGVudGlmaWVyLlxyXG4gICAgICAgICAqXHJcbiAgICAgICAgICogQHBhcmFtIGlkZW50aWZpZXIgSWRlbnRpZmllcyB0aGUgZ2xvYmFsbHktcmVhY2hhYmxlIGZ1bmN0aW9uIHRvIGJlIHJldHVybmVkLlxyXG4gICAgICAgICAqIEByZXR1cm5zIEEgRnVuY3Rpb24gaW5zdGFuY2UuXHJcbiAgICAgICAgICovXHJcbiAgICAgICAgZmluZEpTRnVuY3Rpb246IGZpbmRKU0Z1bmN0aW9uLFxyXG4gICAgICAgIC8qKlxyXG4gICAgICAgICAqIEludm9rZXMgdGhlIHNwZWNpZmllZCBzeW5jaHJvbm91cyBKYXZhU2NyaXB0IGZ1bmN0aW9uLlxyXG4gICAgICAgICAqXHJcbiAgICAgICAgICogQHBhcmFtIGlkZW50aWZpZXIgSWRlbnRpZmllcyB0aGUgZ2xvYmFsbHktcmVhY2hhYmxlIGZ1bmN0aW9uIHRvIGludm9rZS5cclxuICAgICAgICAgKiBAcGFyYW0gYXJnc0pzb24gSlNPTiByZXByZXNlbnRhdGlvbiBvZiBhcmd1bWVudHMgdG8gYmUgcGFzc2VkIHRvIHRoZSBmdW5jdGlvbi5cclxuICAgICAgICAgKiBAcmV0dXJucyBKU09OIHJlcHJlc2VudGF0aW9uIG9mIHRoZSBpbnZvY2F0aW9uIHJlc3VsdC5cclxuICAgICAgICAgKi9cclxuICAgICAgICBpbnZva2VKU0Zyb21Eb3ROZXQ6IGZ1bmN0aW9uIChpZGVudGlmaWVyLCBhcmdzSnNvbikge1xyXG4gICAgICAgICAgICB2YXIgcmVzdWx0ID0gZmluZEpTRnVuY3Rpb24oaWRlbnRpZmllcikuYXBwbHkobnVsbCwgcGFyc2VKc29uV2l0aFJldml2ZXJzKGFyZ3NKc29uKSk7XHJcbiAgICAgICAgICAgIHJldHVybiByZXN1bHQgPT09IG51bGwgfHwgcmVzdWx0ID09PSB1bmRlZmluZWRcclxuICAgICAgICAgICAgICAgID8gbnVsbFxyXG4gICAgICAgICAgICAgICAgOiBKU09OLnN0cmluZ2lmeShyZXN1bHQsIGFyZ1JlcGxhY2VyKTtcclxuICAgICAgICB9LFxyXG4gICAgICAgIC8qKlxyXG4gICAgICAgICAqIEludm9rZXMgdGhlIHNwZWNpZmllZCBzeW5jaHJvbm91cyBvciBhc3luY2hyb25vdXMgSmF2YVNjcmlwdCBmdW5jdGlvbi5cclxuICAgICAgICAgKlxyXG4gICAgICAgICAqIEBwYXJhbSBhc3luY0hhbmRsZSBBIHZhbHVlIGlkZW50aWZ5aW5nIHRoZSBhc3luY2hyb25vdXMgb3BlcmF0aW9uLiBUaGlzIHZhbHVlIHdpbGwgYmUgcGFzc2VkIGJhY2sgaW4gYSBsYXRlciBjYWxsIHRvIGVuZEludm9rZUpTRnJvbURvdE5ldC5cclxuICAgICAgICAgKiBAcGFyYW0gaWRlbnRpZmllciBJZGVudGlmaWVzIHRoZSBnbG9iYWxseS1yZWFjaGFibGUgZnVuY3Rpb24gdG8gaW52b2tlLlxyXG4gICAgICAgICAqIEBwYXJhbSBhcmdzSnNvbiBKU09OIHJlcHJlc2VudGF0aW9uIG9mIGFyZ3VtZW50cyB0byBiZSBwYXNzZWQgdG8gdGhlIGZ1bmN0aW9uLlxyXG4gICAgICAgICAqL1xyXG4gICAgICAgIGJlZ2luSW52b2tlSlNGcm9tRG90TmV0OiBmdW5jdGlvbiAoYXN5bmNIYW5kbGUsIGlkZW50aWZpZXIsIGFyZ3NKc29uKSB7XHJcbiAgICAgICAgICAgIC8vIENvZXJjZSBzeW5jaHJvbm91cyBmdW5jdGlvbnMgaW50byBhc3luYyBvbmVzLCBwbHVzIHRyZWF0XHJcbiAgICAgICAgICAgIC8vIHN5bmNocm9ub3VzIGV4Y2VwdGlvbnMgdGhlIHNhbWUgYXMgYXN5bmMgb25lc1xyXG4gICAgICAgICAgICB2YXIgcHJvbWlzZSA9IG5ldyBQcm9taXNlKGZ1bmN0aW9uIChyZXNvbHZlKSB7XHJcbiAgICAgICAgICAgICAgICB2YXIgc3luY2hyb25vdXNSZXN1bHRPclByb21pc2UgPSBmaW5kSlNGdW5jdGlvbihpZGVudGlmaWVyKS5hcHBseShudWxsLCBwYXJzZUpzb25XaXRoUmV2aXZlcnMoYXJnc0pzb24pKTtcclxuICAgICAgICAgICAgICAgIHJlc29sdmUoc3luY2hyb25vdXNSZXN1bHRPclByb21pc2UpO1xyXG4gICAgICAgICAgICB9KTtcclxuICAgICAgICAgICAgLy8gV2Ugb25seSBsaXN0ZW4gZm9yIGEgcmVzdWx0IGlmIHRoZSBjYWxsZXIgd2FudHMgdG8gYmUgbm90aWZpZWQgYWJvdXQgaXRcclxuICAgICAgICAgICAgaWYgKGFzeW5jSGFuZGxlKSB7XHJcbiAgICAgICAgICAgICAgICAvLyBPbiBjb21wbGV0aW9uLCBkaXNwYXRjaCByZXN1bHQgYmFjayB0byAuTkVUXHJcbiAgICAgICAgICAgICAgICAvLyBOb3QgdXNpbmcgXCJhd2FpdFwiIGJlY2F1c2UgaXQgY29kZWdlbnMgYSBsb3Qgb2YgYm9pbGVycGxhdGVcclxuICAgICAgICAgICAgICAgIHByb21pc2UudGhlbihmdW5jdGlvbiAocmVzdWx0KSB7IHJldHVybiBnZXRSZXF1aXJlZERpc3BhdGNoZXIoKS5iZWdpbkludm9rZURvdE5ldEZyb21KUygwLCAnTWljcm9zb2Z0LkpTSW50ZXJvcCcsICdEb3ROZXREaXNwYXRjaGVyLkVuZEludm9rZScsIG51bGwsIEpTT04uc3RyaW5naWZ5KFthc3luY0hhbmRsZSwgdHJ1ZSwgcmVzdWx0XSwgYXJnUmVwbGFjZXIpKTsgfSwgZnVuY3Rpb24gKGVycm9yKSB7IHJldHVybiBnZXRSZXF1aXJlZERpc3BhdGNoZXIoKS5iZWdpbkludm9rZURvdE5ldEZyb21KUygwLCAnTWljcm9zb2Z0LkpTSW50ZXJvcCcsICdEb3ROZXREaXNwYXRjaGVyLkVuZEludm9rZScsIG51bGwsIEpTT04uc3RyaW5naWZ5KFthc3luY0hhbmRsZSwgZmFsc2UsIGZvcm1hdEVycm9yKGVycm9yKV0pKTsgfSk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9LFxyXG4gICAgICAgIC8qKlxyXG4gICAgICAgICAqIFJlY2VpdmVzIG5vdGlmaWNhdGlvbiB0aGF0IGFuIGFzeW5jIGNhbGwgZnJvbSBKUyB0byAuTkVUIGhhcyBjb21wbGV0ZWQuXHJcbiAgICAgICAgICogQHBhcmFtIGFzeW5jQ2FsbElkIFRoZSBpZGVudGlmaWVyIHN1cHBsaWVkIGluIGFuIGVhcmxpZXIgY2FsbCB0byBiZWdpbkludm9rZURvdE5ldEZyb21KUy5cclxuICAgICAgICAgKiBAcGFyYW0gc3VjY2VzcyBBIGZsYWcgdG8gaW5kaWNhdGUgd2hldGhlciB0aGUgb3BlcmF0aW9uIGNvbXBsZXRlZCBzdWNjZXNzZnVsbHkuXHJcbiAgICAgICAgICogQHBhcmFtIHJlc3VsdE9yRXhjZXB0aW9uTWVzc2FnZSBFaXRoZXIgdGhlIG9wZXJhdGlvbiByZXN1bHQgb3IgYW4gZXJyb3IgbWVzc2FnZS5cclxuICAgICAgICAgKi9cclxuICAgICAgICBlbmRJbnZva2VEb3ROZXRGcm9tSlM6IGZ1bmN0aW9uIChhc3luY0NhbGxJZCwgc3VjY2VzcywgcmVzdWx0T3JFeGNlcHRpb25NZXNzYWdlKSB7XHJcbiAgICAgICAgICAgIHZhciByZXN1bHRPckVycm9yID0gc3VjY2VzcyA/IHJlc3VsdE9yRXhjZXB0aW9uTWVzc2FnZSA6IG5ldyBFcnJvcihyZXN1bHRPckV4Y2VwdGlvbk1lc3NhZ2UpO1xyXG4gICAgICAgICAgICBjb21wbGV0ZVBlbmRpbmdDYWxsKHBhcnNlSW50KGFzeW5jQ2FsbElkKSwgc3VjY2VzcywgcmVzdWx0T3JFcnJvcik7XHJcbiAgICAgICAgfVxyXG4gICAgfTtcclxuICAgIGZ1bmN0aW9uIHBhcnNlSnNvbldpdGhSZXZpdmVycyhqc29uKSB7XHJcbiAgICAgICAgcmV0dXJuIGpzb24gPyBKU09OLnBhcnNlKGpzb24sIGZ1bmN0aW9uIChrZXksIGluaXRpYWxWYWx1ZSkge1xyXG4gICAgICAgICAgICAvLyBJbnZva2UgZWFjaCByZXZpdmVyIGluIG9yZGVyLCBwYXNzaW5nIHRoZSBvdXRwdXQgZnJvbSB0aGUgcHJldmlvdXMgcmV2aXZlcixcclxuICAgICAgICAgICAgLy8gc28gdGhhdCBlYWNoIG9uZSBnZXRzIGEgY2hhbmNlIHRvIHRyYW5zZm9ybSB0aGUgdmFsdWVcclxuICAgICAgICAgICAgcmV0dXJuIGpzb25SZXZpdmVycy5yZWR1Y2UoZnVuY3Rpb24gKGxhdGVzdFZhbHVlLCByZXZpdmVyKSB7IHJldHVybiByZXZpdmVyKGtleSwgbGF0ZXN0VmFsdWUpOyB9LCBpbml0aWFsVmFsdWUpO1xyXG4gICAgICAgIH0pIDogbnVsbDtcclxuICAgIH1cclxuICAgIGZ1bmN0aW9uIGZvcm1hdEVycm9yKGVycm9yKSB7XHJcbiAgICAgICAgaWYgKGVycm9yIGluc3RhbmNlb2YgRXJyb3IpIHtcclxuICAgICAgICAgICAgcmV0dXJuIGVycm9yLm1lc3NhZ2UgKyBcIlxcblwiICsgZXJyb3Iuc3RhY2s7XHJcbiAgICAgICAgfVxyXG4gICAgICAgIGVsc2Uge1xyXG4gICAgICAgICAgICByZXR1cm4gZXJyb3IgPyBlcnJvci50b1N0cmluZygpIDogJ251bGwnO1xyXG4gICAgICAgIH1cclxuICAgIH1cclxuICAgIGZ1bmN0aW9uIGZpbmRKU0Z1bmN0aW9uKGlkZW50aWZpZXIpIHtcclxuICAgICAgICBpZiAoY2FjaGVkSlNGdW5jdGlvbnMuaGFzT3duUHJvcGVydHkoaWRlbnRpZmllcikpIHtcclxuICAgICAgICAgICAgcmV0dXJuIGNhY2hlZEpTRnVuY3Rpb25zW2lkZW50aWZpZXJdO1xyXG4gICAgICAgIH1cclxuICAgICAgICB2YXIgcmVzdWx0ID0gd2luZG93O1xyXG4gICAgICAgIHZhciByZXN1bHRJZGVudGlmaWVyID0gJ3dpbmRvdyc7XHJcbiAgICAgICAgaWRlbnRpZmllci5zcGxpdCgnLicpLmZvckVhY2goZnVuY3Rpb24gKHNlZ21lbnQpIHtcclxuICAgICAgICAgICAgaWYgKHNlZ21lbnQgaW4gcmVzdWx0KSB7XHJcbiAgICAgICAgICAgICAgICByZXN1bHQgPSByZXN1bHRbc2VnbWVudF07XHJcbiAgICAgICAgICAgICAgICByZXN1bHRJZGVudGlmaWVyICs9ICcuJyArIHNlZ21lbnQ7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgZWxzZSB7XHJcbiAgICAgICAgICAgICAgICB0aHJvdyBuZXcgRXJyb3IoXCJDb3VsZCBub3QgZmluZCAnXCIgKyBzZWdtZW50ICsgXCInIGluICdcIiArIHJlc3VsdElkZW50aWZpZXIgKyBcIicuXCIpO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgfSk7XHJcbiAgICAgICAgaWYgKHJlc3VsdCBpbnN0YW5jZW9mIEZ1bmN0aW9uKSB7XHJcbiAgICAgICAgICAgIHJldHVybiByZXN1bHQ7XHJcbiAgICAgICAgfVxyXG4gICAgICAgIGVsc2Uge1xyXG4gICAgICAgICAgICB0aHJvdyBuZXcgRXJyb3IoXCJUaGUgdmFsdWUgJ1wiICsgcmVzdWx0SWRlbnRpZmllciArIFwiJyBpcyBub3QgYSBmdW5jdGlvbi5cIik7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG4gICAgdmFyIERvdE5ldE9iamVjdCA9IC8qKiBAY2xhc3MgKi8gKGZ1bmN0aW9uICgpIHtcclxuICAgICAgICBmdW5jdGlvbiBEb3ROZXRPYmplY3QoX2lkKSB7XHJcbiAgICAgICAgICAgIHRoaXMuX2lkID0gX2lkO1xyXG4gICAgICAgIH1cclxuICAgICAgICBEb3ROZXRPYmplY3QucHJvdG90eXBlLmludm9rZU1ldGhvZCA9IGZ1bmN0aW9uIChtZXRob2RJZGVudGlmaWVyKSB7XHJcbiAgICAgICAgICAgIHZhciBhcmdzID0gW107XHJcbiAgICAgICAgICAgIGZvciAodmFyIF9pID0gMTsgX2kgPCBhcmd1bWVudHMubGVuZ3RoOyBfaSsrKSB7XHJcbiAgICAgICAgICAgICAgICBhcmdzW19pIC0gMV0gPSBhcmd1bWVudHNbX2ldO1xyXG4gICAgICAgICAgICB9XHJcbiAgICAgICAgICAgIHJldHVybiBpbnZva2VQb3NzaWJsZUluc3RhbmNlTWV0aG9kKG51bGwsIG1ldGhvZElkZW50aWZpZXIsIHRoaXMuX2lkLCBhcmdzKTtcclxuICAgICAgICB9O1xyXG4gICAgICAgIERvdE5ldE9iamVjdC5wcm90b3R5cGUuaW52b2tlTWV0aG9kQXN5bmMgPSBmdW5jdGlvbiAobWV0aG9kSWRlbnRpZmllcikge1xyXG4gICAgICAgICAgICB2YXIgYXJncyA9IFtdO1xyXG4gICAgICAgICAgICBmb3IgKHZhciBfaSA9IDE7IF9pIDwgYXJndW1lbnRzLmxlbmd0aDsgX2krKykge1xyXG4gICAgICAgICAgICAgICAgYXJnc1tfaSAtIDFdID0gYXJndW1lbnRzW19pXTtcclxuICAgICAgICAgICAgfVxyXG4gICAgICAgICAgICByZXR1cm4gaW52b2tlUG9zc2libGVJbnN0YW5jZU1ldGhvZEFzeW5jKG51bGwsIG1ldGhvZElkZW50aWZpZXIsIHRoaXMuX2lkLCBhcmdzKTtcclxuICAgICAgICB9O1xyXG4gICAgICAgIERvdE5ldE9iamVjdC5wcm90b3R5cGUuZGlzcG9zZSA9IGZ1bmN0aW9uICgpIHtcclxuICAgICAgICAgICAgdmFyIHByb21pc2UgPSBpbnZva2VNZXRob2RBc3luYygnTWljcm9zb2Z0LkpTSW50ZXJvcCcsICdEb3ROZXREaXNwYXRjaGVyLlJlbGVhc2VEb3ROZXRPYmplY3QnLCB0aGlzLl9pZCk7XHJcbiAgICAgICAgICAgIHByb21pc2UuY2F0Y2goZnVuY3Rpb24gKGVycm9yKSB7IHJldHVybiBjb25zb2xlLmVycm9yKGVycm9yKTsgfSk7XHJcbiAgICAgICAgfTtcclxuICAgICAgICBEb3ROZXRPYmplY3QucHJvdG90eXBlLnNlcmlhbGl6ZUFzQXJnID0gZnVuY3Rpb24gKCkge1xyXG4gICAgICAgICAgICByZXR1cm4gXCJfX2RvdE5ldE9iamVjdDpcIiArIHRoaXMuX2lkO1xyXG4gICAgICAgIH07XHJcbiAgICAgICAgcmV0dXJuIERvdE5ldE9iamVjdDtcclxuICAgIH0oKSk7XHJcbiAgICB2YXIgZG90TmV0T2JqZWN0VmFsdWVGb3JtYXQgPSAvXl9fZG90TmV0T2JqZWN0XFw6KFxcZCspJC87XHJcbiAgICBhdHRhY2hSZXZpdmVyKGZ1bmN0aW9uIHJldml2ZURvdE5ldE9iamVjdChrZXksIHZhbHVlKSB7XHJcbiAgICAgICAgaWYgKHR5cGVvZiB2YWx1ZSA9PT0gJ3N0cmluZycpIHtcclxuICAgICAgICAgICAgdmFyIG1hdGNoID0gdmFsdWUubWF0Y2goZG90TmV0T2JqZWN0VmFsdWVGb3JtYXQpO1xyXG4gICAgICAgICAgICBpZiAobWF0Y2gpIHtcclxuICAgICAgICAgICAgICAgIHJldHVybiBuZXcgRG90TmV0T2JqZWN0KHBhcnNlSW50KG1hdGNoWzFdKSk7XHJcbiAgICAgICAgICAgIH1cclxuICAgICAgICB9XHJcbiAgICAgICAgLy8gVW5yZWNvZ25pemVkIC0gbGV0IGFub3RoZXIgcmV2aXZlciBoYW5kbGUgaXRcclxuICAgICAgICByZXR1cm4gdmFsdWU7XHJcbiAgICB9KTtcclxuICAgIGZ1bmN0aW9uIGFyZ1JlcGxhY2VyKGtleSwgdmFsdWUpIHtcclxuICAgICAgICByZXR1cm4gdmFsdWUgaW5zdGFuY2VvZiBEb3ROZXRPYmplY3QgPyB2YWx1ZS5zZXJpYWxpemVBc0FyZygpIDogdmFsdWU7XHJcbiAgICB9XHJcbn0pKERvdE5ldCB8fCAoRG90TmV0ID0ge30pKTtcclxuLy8jIHNvdXJjZU1hcHBpbmdVUkw9TWljcm9zb2Z0LkpTSW50ZXJvcC5qcy5tYXAiXSwic291cmNlUm9vdCI6IiJ9